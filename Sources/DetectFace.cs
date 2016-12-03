using System.Collections.Generic;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace FaceDetection.Sources
{
	internal class DetectFace
	{
		private const string EyeFileName = "Cascades/haarcascade_eye.xml";
		private const string MouthFileName = "Cascades/haarcascade_mouth.xml";
		private const string NoseFileName = "Cascades/haarcascade_nose.xml";


		public static Mat Detect(Mat image, int selectedAlgorithmIndex, bool detectEyes = false, bool detectMouth = false, bool detectNose = false)
		{
			var faces = new List<Rectangle>();
			var ugray = new UMat();
			var fileName = GetFileName(selectedAlgorithmIndex);
			
			using (var face = new CascadeClassifier(fileName))
			{
				CvInvoke.CvtColor(image, ugray, ColorConversion.Bgr2Gray);
				CvInvoke.EqualizeHist(ugray, ugray);
				Rectangle[] facesDetected = face.DetectMultiScale(
						ugray,
						1.1,
						10,
						new Size(20, 20));
					faces.AddRange(facesDetected);
			}
			foreach (var face in faces)
				CvInvoke.Rectangle(image, face, new Bgr(Color.Red).MCvScalar, 3);
			if (detectEyes)
			{
				var eyes = new List<Rectangle>();
				DetectItem(faces, ugray, eyes, EyeFileName);
				foreach (var eye in eyes)
					CvInvoke.Rectangle(image, eye, new Bgr(Color.Blue).MCvScalar, 3);
			}
			if (detectMouth)
			{
				var mouth = new List<Rectangle>();
				DetectItem(faces, ugray, mouth, MouthFileName);
				foreach (var m in mouth)
					CvInvoke.Rectangle(image, m, new Bgr(Color.Green).MCvScalar, 3);
			}
			if (detectNose)
			{
				var noses = new List<Rectangle>();
				DetectItem(faces, ugray, noses, NoseFileName);
				foreach (var nose in noses)
					CvInvoke.Rectangle(image, nose, new Bgr(Color.BlueViolet).MCvScalar, 3);
			}
			return image;
		}

		private static void DetectItem(IEnumerable<Rectangle> faces, UMat ugray, IList<Rectangle> list, string fileName)
		{
			using (var item = new CascadeClassifier(fileName))
			{
				foreach (var f in faces)
				{
					//Get the region of interest on the faces
					using (var faceRegion = new UMat(ugray, f))
					{
						var itemsDetected = item.DetectMultiScale(
							faceRegion,
							1.1,
							10,
							new Size(20, 20));

						foreach (var i in itemsDetected)
						{
							var itemRect = i;
							itemRect.Offset(f.X, f.Y);
							list.Add(itemRect);
						}
					}
				}
			}
		}

		private static string GetFileName(int index)
		{
			/*"Frontal face - default",
				"Frontal face - Alt",
				"Frontal face - Alt 2",
				"Frontal face - Alt tree",
				"Profile face"*/
			switch (index)
			{
				case 0:
					return "Cascades\\haarcascade_frontalface_default.xml";
				case 1:
					return "Cascades\\haarcascade_frontalface_alt.xml";
				case 2:
					return "Cascades\\haarcascade_frontalface_alt2.xml";
				case 3:
					return "Cascades\\haarcascade_frontalface_alt_tree.xml";
				case 4:
					return "Cascades\\haarcascade_profil_face.xml";
			}
			return "";
		}
	}
}
