using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
			webcam = new WebCam();
			InitializeComponent();
		}

		private void loadFileCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (loadFileCheckBox.Checked)
			{
				webcamCheckBox.Checked = false;
				webcamConfigurationButton.Enabled = false;
				openFileButton.Enabled = true;
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
				webcamConfigurationButton.Enabled = true;
				webcam.InitializeWebCam();
			}
			else
			{
				webcamConfigurationButton.Enabled = false;
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
				PlayVideo(pictureBox);
			}
		}

		private void detectButton_Click(object sender, EventArgs e)
		{
			pictureBox.Image = DetectFace.Detect((Mat) pictureBox.Image);
		}

		private void webcamConfigurationButton_Click(object sender, EventArgs e)
		{
		}

		private static Mat ScaleImage(Mat image)
		{
			var ratioX = (double)pictureWidth / image.Width;
			var ratioY = (double)pictureHeight / image.Height;
			var ratio = Math.Min(ratioX, ratioY);

			var newWidth = (int)(image.Width * ratio);
			var newHeight = (int)(image.Height * ratio);

			//var newImage = image.Size.Height = newHeight; //new Bitmap(newWidth, newHeight);

			//using (var graphics = Graphics.FromImage(newImage))
			//	graphics.DrawImage(image, 0, 0, newWidth, newHeight);

			return null;
		}

		private void PlayVideo(PictureBox pictureBox)
		{
			Capture movie = new Capture(fileName);
			//pictureBox.Image = ScaleImage(movie.QueryFrame().Bitmap);
		}

		private void saveFileButton_Click(object sender, EventArgs e)
		{
			//saveFileDialog.Filter = "JPEG|*.jpg|PNG|*.png|BMP|*.bmp|MP4|*.mp4";
			//saveFileDialog.Title = "Save an image file";
			//saveFileDialog.ShowDialog();

			//if (!string.IsNullOrEmpty(saveFileDialog.FileName))
			//{
			//	var stream = (FileStream)saveFileDialog.OpenFile();
			//	switch (saveFileDialog.FilterIndex)
			//	{
			//		case 1:
			//			saveFileButton.Image.Save(stream, ImageFormat.Jpeg);
			//			break;
			//		case 2:
			//			saveFileButton.Image.Save(stream, ImageFormat.Jpeg);
			//			break;
			//		case 3:
			//			saveFileButton.Image.Save(stream, ImageFormat.Jpeg);
			//			break;
			//	}
			//	stream.Close();
			//}
		}
	}
}
