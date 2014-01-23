using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;
using UnityEngine;
using StrangeTest.Common;

namespace StrangeTest.Modules.PauseMenu
{
	public class PauseMenuView : View
	{
		public Signal ResumePressed = new Signal();
		public Signal SavePressed 	= new Signal();
		public Signal LeavePressed 	= new Signal();

		private Camera _camera;
		public Camera pauseCam
		{
			get { return _camera; }
			set
			{
				_camera = value;
				InitCamValues();
			}
		}

		Vector3 _screenCorner = Vector3.zero;

		void OnGUI ()
		{
			GUI.Box(new Rect(_screenCorner.x + 10, _screenCorner.y + 10, 100, 130), "Pause Menu");
			
			if (GUI.Button(new Rect(_screenCorner.x + 20, _screenCorner.y + 40, 80, 20), "RESUME GAME"))
			{
				ResumePressed.Dispatch();
			}
			
			if (GUI.Button(new Rect(_screenCorner.x + 20, _screenCorner.y + 70, 80, 20), "SAVE GAME"))
			{
				SavePressed.Dispatch();
			}
			
			if (GUI.Button(new Rect(_screenCorner.x + 20, _screenCorner.y + 100, 80, 20), "LEAVE GAME"))
			{
				LeavePressed.Dispatch();
			}
		}

		void Update()
		{
			if (Input.GetButtonDown(InputeName.PAUSE))
			{
				ResumePressed.Dispatch();
			}
		}

		private void InitCamValues()
		{
			_screenCorner = _camera.ViewportToScreenPoint(Vector3.zero);
		}
	}
}