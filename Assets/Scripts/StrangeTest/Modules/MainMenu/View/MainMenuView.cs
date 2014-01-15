using strange.extensions.mediation.impl;
using UnityEngine;
using strange.extensions.signal.impl;

namespace StrangeTest.Modules.MainMenu
{
	public class MainMenuView : View
	{
		public Signal NewPressed = new Signal();
		public Signal LoadPressed = new Signal();
		public Signal QuitPressed = new Signal();

		void OnGUI ()
		{
			GUI.Box(new Rect(10,10,100,130), "Main Menu");
			
			if (GUI.Button(new Rect(20,40,80,20), "NEW"))
			{
				NewPressed.Dispatch();
			}
			
			if (GUI.Button(new Rect(20,70,80,20), "LOAD"))
			{
				LoadPressed.Dispatch();
			}

			if (GUI.Button(new Rect(20,100,80,20), "QUIT"))
			{
				QuitPressed.Dispatch();
			}
		}
	}
}

