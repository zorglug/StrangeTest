using System;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using UnityEngine;
using StrangeTest.Common;
using StrangeTest.Modules.PauseMenu;
using strange.extensions.context.impl;

namespace StrangeTest.Modules.Game
{
	public class ShowPauseMenu : Command
	{
		[Inject(ContextKeys.CONTEXT_VIEW)]
		public GameObject ContextView { get; set; }

		public override void Execute ()
		{
			if (GameObject.FindGameObjectWithTag(Tags.PAUSE_MENU_CONTEXT) != null)
			{
				// Pause menu already present
				return;
			}

			Application.LoadLevelAdditive(Levels.PAUSE_MENU);
		}
	}
}

