using System.Collections.Generic;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace FaceDetection.Sources
{
	class DetectFace
	{
		private const string faceFileName = "haarcascade_frontalface_default.xml";
		private const string eyeFileName = "haarcascade_eye.xml";
		public static Mat Detect(string fileName)
		{
			var tmpImage = new Mat(fileName, LoadImageType.Color);


			var faces = new List<Rectangle>();
			var eyes = new List<Rectangle>();
			using (var face = new CascadeClassifier(faceFileName))
			using (var eye = new CascadeClassifier(eyeFileName))
			{
				using (var ugray = new UMat())
				{
					CvInvoke.CvtColor(tmpImage, ugray, ColorConversion.Bgr2Gray);

					CvInvoke.EqualizeHist(ugray, ugray);
					var facesDetected = face.DetectMultiScale(
						ugray,
						1.1,
						10,
						new Size(20, 20));

					faces.AddRange(facesDetected);

					foreach (var f in facesDetected)
					{
						//Get the region of interest on the faces
						using (var faceRegion = new UMat(ugray, f))
						{
							var eyesDetected = eye.DetectMultiScale(
								faceRegion,
								1.1,
								10,
								new Size(20, 20));

							foreach (var e in eyesDetected)
							{
								var eyeRect = e;
								eyeRect.Offset(f.X, f.Y);
								eyes.Add(eyeRect);
							}
						}
					}
				}
			}
			foreach (var face in faces)
				CvInvoke.Rectangle(tmpImage, face, new Bgr(Color.Red).MCvScalar, 2);
			foreach (var eye in eyes)
				CvInvoke.Rectangle(tmpImage, eye, new Bgr(Color.Blue).MCvScalar, 2);
			return tmpImage;
		}

		public static Mat Detect(Mat image)
		{
			var faces = new List<Rectangle>();
			var eyes = new List<Rectangle>();
			using (var face = new CascadeClassifier(faceFileName))
			using (var eye = new CascadeClassifier(eyeFileName))
			{
				using (var ugray = new UMat())
				{
					CvInvoke.CvtColor(image, ugray, ColorConversion.Bgr2Gray);

					CvInvoke.EqualizeHist(ugray, ugray);
					var facesDetected = face.DetectMultiScale(
						ugray,
						1.1,
						10,
						new Size(20, 20));

					faces.AddRange(facesDetected);

					foreach (var f in facesDetected)
					{
						//Get the region of interest on the faces
						using (var faceRegion = new UMat(ugray, f))
						{
							var eyesDetected = eye.DetectMultiScale(
								faceRegion,
								1.1,
								10,
								new Size(20, 20));

							foreach (var e in eyesDetected)
							{
								var eyeRect = e;
								eyeRect.Offset(f.X, f.Y);
								eyes.Add(eyeRect);
							}
						}
					}
				}
			}
			foreach (var face in faces)
				CvInvoke.Rectangle(image, face, new Bgr(Color.Red).MCvScalar, 2);
			foreach (var eye in eyes)
				CvInvoke.Rectangle(image, eye, new Bgr(Color.Blue).MCvScalar, 2);
			return image;
		}
	}
}
