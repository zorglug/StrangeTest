using strange.extensions.command.impl;
using strange.extensions.context.api;
using UnityEngine;
using StrangeTest.Common;

namespace StrangeTest.Modules.MainMenu
{
	public class MainMenuStartup : Command
	{
		[Inject(ContextKeys.CONTEXT_VIEW)]
		public GameObject ContextView { get; set; }

		public override void Execute()
		{
			Debug.Log("MainMenuStartup Called! Got ContextView: " + ContextView);

			GameObject mainContext = GameObject.FindWithTag(Tags.MAIN_CONTEXT);

			if (mainContext == null)
			{
				//Module is running in isolation
				return;
			}

			//Reparenting to main context
			ContextView.transform.parent = mainContext.transform;
		}
	}
}

