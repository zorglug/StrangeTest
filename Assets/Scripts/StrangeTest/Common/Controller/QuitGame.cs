using UnityEngine;
using strange.extensions.command.impl;

namespace StrangeTest.Common
{
	public class QuitGame : Command
	{
		public override void Execute ()
		{
			Debug.Log("QuitGame command called!");
		}
	}
}

