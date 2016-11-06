using System;
using System.Drawing;
using System.Windows.Forms;

namespace FaceDetection
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			webcam = new WebCam();
			InitializeComponent();
		}

		private string fileName;
		private WebCam webcam;
		private static Image ScaleImage(Image image, int maxWidth, int maxHeight)
		{
			var ratioX = (double)maxWidth / image.Width;
			var ratioY = (double)maxHeight / image.Height;
			var ratio = Math.Min(ratioX, ratioY);

			var newWidth = (int)(image.Width * ratio);
			var newHeight = (int)(image.Height * ratio);

			var newImage = new Bitmap(newWidth, newHeight);

			using (var graphics = Graphics.FromImage(newImage))
				graphics.DrawImage(image, 0, 0, newWidth, newHeight);

			return newImage;
		}

		private void buttonOpenFile_Click(object sender, EventArgs e)
		{
			openFileDialog.Filter = "JPEG|*.jpg|PNG|*.png|BMP|*.bmp";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				var bitmap = Bitmap.FromFile(openFileDialog.FileName);
				pictureBox1.Image = ScaleImage(bitmap, 640, 360);
				fileName = openFileDialog.FileName;
			}

		}

		private void buttonStartDetection_Click(object sender, EventArgs e)
		{

		}

		private void checkCam_CheckedChanged(object sender, EventArgs e)
		{
			if (checkCam.Checked)
			{
				checkFile.Checked = false;
				webcam.InitializeWebCam(ref pictureBox1);
				webcam.Start();
			}
			else
			{
				webcam.Stop();
			}
		}
	}
}
