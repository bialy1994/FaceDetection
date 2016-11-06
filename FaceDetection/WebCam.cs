using System;
using WebCam_Capture;

namespace FaceDetection
{
	class WebCam
	{
		private const int fps = 30;
		private WebCamCapture webCam;
		private System.Windows.Forms.PictureBox _frame;

		public void InitializeWebCam(ref System.Windows.Forms.PictureBox imageControl)
		{
			webCam = new WebCamCapture
			{
				FrameNumber = 0,
				TimeToCapture_milliseconds = fps
			};
			webCam.ImageCaptured += webcam_ImageCaptured;
			_frame = imageControl;
		}

		private void webcam_ImageCaptured(object source, WebcamEventArgs e)
		{
			GC.Collect();
			_frame.Image = e.WebCamImage;
		}

		public void Start()
		{
			webCam.Start(0);
		}

		public void Stop()
		{
			webCam.Stop();
		}
	}
}
