using System.Collections.Generic;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.CvEnum;

namespace FaceDetection
{
	class DetectFace
	{
		private const string FaceFileName = "haarcascade_frontalface_default.xml";
		private const string eyeFileName = "haarcascade_eye.xml";
		public static Image Detect(string fileName)
		{
			var tmpImage = new Mat(fileName, LoadImageType.Color);
			var faces = new List<Rectangle>();
			var eyes = new List<Rectangle>();
			using (CascadeClassifier face = new CascadeClassifier(FaceFileName))
			using (CascadeClassifier eye = new CascadeClassifier(eyeFileName))
			{
				using (UMat ugray = new UMat())
				{
					CvInvoke.CvtColor(tmpImage, ugray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);

					//normalizes brightness and increases contrast of the image
					CvInvoke.EqualizeHist(ugray, ugray);

					//Detect the faces  from the gray scale image and store the locations as rectangle
					//The first dimensional is the channel
					//The second dimension is the index of the rectangle in the specific channel
					Rectangle[] facesDetected = face.DetectMultiScale(
						ugray,
						1.1,
						10,
						new Size(20, 20));

					faces.AddRange(facesDetected);

					foreach (Rectangle f in facesDetected)
					{
						//Get the region of interest on the faces
						using (UMat faceRegion = new UMat(ugray, f))
						{
							Rectangle[] eyesDetected = eye.DetectMultiScale(
							   faceRegion,
							   1.1,
							   10,
							   new Size(20, 20));

							foreach (Rectangle e in eyesDetected)
							{
								Rectangle eyeRect = e;
								eyeRect.Offset(f.X, f.Y);
								eyes.Add(eyeRect);
							}
						}
					}
				}
			}
			return tmpImage.Bitmap;
		}
	}
}
