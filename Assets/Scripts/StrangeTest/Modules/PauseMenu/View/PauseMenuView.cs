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
		
		void OnGUI ()
		{
			//TODO: Center GUI...

			GUI.Box(new Rect(10,10,100,130), "Pause Menu");
			
			if (GUI.Button(new Rect(20,40,80,20), "RESUME GAME"))
			{
				ResumePressed.Dispatch();
			}
			
			if (GUI.Button(new Rect(20,70,80,20), "SAVE GAME"))
			{
				SavePressed.Dispatch();
			}
			
			if (GUI.Button(new Rect(20,100,80,20), "LEAVE GAME"))
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
	}
}