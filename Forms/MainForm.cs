using System;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using FaceDetection.Sources;

namespace FaceDetection
{
	public partial class MainForm : Form
	{
		private readonly Capture _capture = null;
		private bool _captureInProgress;
		private bool _detect;
		private int selectedAlgorithmIndex;

		public MainForm()
		{
			InitializeComponent();
			CvInvoke.UseOpenCL = false;
			try
			{
				_capture = new Capture();
				_capture.ImageGrabbed += ProcessFrame;
			}
			catch (NullReferenceException excpt)
			{
				MessageBox.Show(excpt.Message);
			}
			selectedAlgorithmIndex = algorithmComboBox.SelectedIndex;
		}

		private void ProcessFrame(object sender, EventArgs arg)
		{
			var frame = new Mat();
			_capture.Retrieve(frame, 0);
			pictureBox.Image = _detect ? DetectFace.Detect(frame, selectedAlgorithmIndex, eyesCheckBox.Checked, mouthCheckBox.Checked, noseCheckBox.Checked) : frame;
		}


		private void loadFileCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (loadFileCheckBox.Checked)
			{
				webcamCheckBox.Checked = false;
				openFileButton.Enabled = true;
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
				loadFileCheckBox.Checked = false;
				openFileButton.Enabled = false;
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

		private void openFileButton_Click(object sender, EventArgs e)
		{
			openFileDialog.Filter = "JPEG|*.jpg|PNG|*.png|BMP|*.bmp|MP4|*.mp4";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				var image = new Mat(openFileDialog.FileName, LoadImageType.Color);
				pictureBox.Image = image;
				fileName = openFileDialog.FileName;
			}
		}

		private void detectButton_Click(object sender, EventArgs e)
		{
			if (pictureBox.Image == null)
				return;

			if (loadFileCheckBox.Checked)
			{
				pictureBox.Image = DetectFace.Detect((Mat)pictureBox.Image, selectedAlgorithmIndex, eyesCheckBox.Checked,mouthCheckBox.Checked,noseCheckBox.Checked);
				return;
			}

			_detect = !_detect;
			if(!loadFileCheckBox.Checked)
				detectButton.Text = _detect ? "Stop detection" : "Start detection";
		}

		private void algorithmComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedAlgorithmIndex = algorithmComboBox.SelectedIndex;
		}
	}
}
