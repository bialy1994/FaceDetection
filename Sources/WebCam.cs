using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.UI;
using WebCam_Capture;

namespace FaceDetection
{
	class WebCam
	{
		private Capture _capture = null;
		private ImageBox _frame;
		private bool _captureInProgress;

		public void InitializeWebCam()
		{
			CvInvoke.UseOpenCL = false;
			try
			{
				_capture=new Capture();
				_capture.ImageGrabbed += ProcessFrame;
			}
			catch (NullReferenceException e)
			{

				MessageBox.Show(e.Message);
			}
		}

		private void ProcessFrame(object sender, EventArgs arg)
		{
			Mat frame = new Mat();
			_capture.Retrieve(frame, 0);
			_frame.Image = frame;
		}

		private void webcam_ImageCaptured(object sender, EventArgs e)
		{
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
	}
}