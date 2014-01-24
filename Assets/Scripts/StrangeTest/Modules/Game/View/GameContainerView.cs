using System;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;
using UnityEngine;
using StrangeTest.Common;

namespace StrangeTest.Modules.Game
{
	public class GameContainerView : View
	{
		public Signal PausePressed = new Signal();

		public Signal RandomNodePressed = new Signal();

		void Update()
		{
			if (Input.GetButtonDown(InputeName.PAUSE))
			{
				PausePressed.Dispatch();
			}

			if (Input.GetKeyDown(KeyCode.F15))
			{
				RandomNodePressed.Dispatch();
			}
		}
	}
}

