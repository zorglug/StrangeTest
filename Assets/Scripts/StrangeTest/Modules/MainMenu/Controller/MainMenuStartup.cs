using strange.extensions.command.impl;
using strange.extensions.context.api;
using UnityEngine;

namespace StrangeTest.Modules.MainMenu
{
	public class MainMenuStartup : Command
	{
		[Inject(ContextKeys.CONTEXT_VIEW)]
		public GameObject ContextView { get; set; }

		public override void Execute()
		{
			Debug.Log("MainMenuStartup Called!");

			//TODO: Anything to do here?
		}
	}
}

