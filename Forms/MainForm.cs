using System;
using System.Threading;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using FaceDetection.Sources;

namespace FaceDetection
{
	public partial class MainForm : Form
	{
		

		public MainForm()
		{
			InitializeComponent();
			CvInvoke.UseOpenCL = false;
		}

		private void ProcessFrame(object sender, EventArgs arg)
		{
			if (webcamCheckBox.Checked)
			{
				var frame = new Mat();
				_capture.Retrieve(frame, 0);
				pictureBox.Image = _detect
					? DetectFace.Detect(frame, _selectedAlgorithmIndex, eyesCheckBox.Checked, mouthCheckBox.Checked,
						noseCheckBox.Checked)
					: frame;
			}else if (loadFileCheckBox.Checked)
			{
				var frame = _capture.QueryFrame();
				pictureBox.Image = _detect
					? DetectFace.Detect(frame, _selectedAlgorithmIndex, eyesCheckBox.Checked, mouthCheckBox.Checked,
						noseCheckBox.Checked)
					: frame;
				Thread.Sleep((int) (1000.0/_frameRate));
			}
			GC.Collect();
		}


		private void loadFileCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (loadFileCheckBox.Checked)
			{
				webcamCheckBox.Checked = false;
				openFileButton.Enabled = true;
				openVideoCheckBox.Enabled = true;
				openImageCheckBox.Enabled = true;
				detectButton.Text = "detect";
				_detect = false;
			}
			else
			{
				openFileButton.Enabled = false;
			}
		}

		private void webcamCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (webcamCheckBox.Checked)
			{
				try
				{
					_capture = new Capture();
					_capture.ImageGrabbed += ProcessFrame;
				}
				catch (NullReferenceException excpt)
				{
					MessageBox.Show(excpt.Message);
				}
				loadFileCheckBox.Checked = false;
				openFileButton.Enabled = false;
				saveFileButton.Enabled = false;
				openVideoCheckBox.Enabled = false;
				openImageCheckBox.Enabled = false;
				detectButton.Text = "Start detection";
				_detect = false;
			}
			if (_capture != null)
			{
				if (_captureInProgress)
				{  //stop the capture
					_capture.Pause();
				}
				else
				{
					//start the capture
					_capture.Start();
				}

				_captureInProgress = !_captureInProgress;
			}
		}

		private void detectButton_Click(object sender, EventArgs e)
		{
			if (pictureBox.Image == null)
				return;

			if (loadFileCheckBox.Checked && openImageCheckBox.Checked)
			{
				pictureBox.Image = DetectFace.Detect((Mat)pictureBox.Image, _selectedAlgorithmIndex, eyesCheckBox.Checked,mouthCheckBox.Checked,noseCheckBox.Checked);
				return;
			}

			_detect = !_detect;
			if(!loadFileCheckBox.Checked)
				detectButton.Text = _detect ? "Stop detection" : "Start detection";
		}

		private void algorithmComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			_selectedAlgorithmIndex = algorithmComboBox.SelectedIndex;
		}

		private void openFileButton_Click(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog();
			if (openImageCheckBox.Checked)
			{
				openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					Application.Idle -= ProcessFrame;
					GC.Collect();
					var image = new Mat(openFileDialog.FileName, LoadImageType.Color);
					pictureBox.Image = image;
					saveFileButton.Enabled = true;
				}
			}
			else if (openVideoCheckBox.Checked)
			{
				openFileDialog.Filter = "Video files(*.mp4, *.avi) | *.mp4; *.avi";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					_capture = null;
					_capture = new Capture(openFileDialog.FileName);
					_capture.SetCaptureProperty(CapProp.FrameWidth, 640);
					_capture.SetCaptureProperty(CapProp.FrameHeight, 360);
					_frameRate = _capture.GetCaptureProperty(CapProp.Fps);
					Application.Idle += ProcessFrame;
					
				}
			}
		}

		private void saveFileButton_Click(object sender, EventArgs e)
		{
			var saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "JPG|*.jpg|JPEG|*.jpeg|JPE|*.jpe|JFIF|*.jfif|PNG|*.png";
			saveFileDialog.ShowDialog();
			if (!string.IsNullOrEmpty(saveFileDialog.FileName))
			{
				pictureBox.Image.Save(saveFileDialog.FileName);
			}
		}

		private void openImageCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (!openImageCheckBox.Checked && !openVideoCheckBox.Checked)
			{
				openFileButton.Enabled = false;
			}
			if (openImageCheckBox.Checked)
			{
				openVideoCheckBox.Checked = false;
				openFileButton.Enabled = true;
			}
		}

		private void openVideoCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (!openImageCheckBox.Checked && !openVideoCheckBox.Checked)
			{
				openFileButton.Enabled = false;
			}
			if (openVideoCheckBox.Checked)
			{
				openImageCheckBox.Checked = false;
				openFileButton.Enabled = true;
			}
		}
	}
}
