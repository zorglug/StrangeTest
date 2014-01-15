using strange.extensions.context.api;
using strange.extensions.command.impl;
using UnityEngine;

namespace StrangeTest.Modules.PauseMenu
{
	public class ResumeGame : Command
	{
		[Inject(ContextKeys.CONTEXT_VIEW)]
		public GameObject ContextView { get; set; }

		public override void Execute ()
		{
			Debug.Log("ResumeGame called!");
		}
	}
}

