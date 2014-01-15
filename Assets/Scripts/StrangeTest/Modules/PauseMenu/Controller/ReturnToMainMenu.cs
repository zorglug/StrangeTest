using strange.extensions.command.impl;
using UnityEngine;

namespace StrangeTest.Modules.PauseMenu
{
	public class ReturnToMainMenu : Command
	{
		public override void Execute ()
		{
			Debug.Log("ReturnToMainMenu called!");
		}
	}
}

