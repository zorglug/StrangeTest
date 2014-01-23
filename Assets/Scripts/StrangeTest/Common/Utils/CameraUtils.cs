using System;
using UnityEngine;

namespace StrangeTest.Common
{
	public static class CameraUtils
	{
		public static Camera GetCameraByName(string name)
		{
			foreach (Camera cam in Camera.allCameras)
			{
				if (cam.name == name)
				{
					return cam;
				}
			}
			
			throw new UnityException("Could not find a camera named: " + CameraNames.GAME_CAMERA);
		}
	}
}

