using strange.extensions.command.impl;
using UnityEngine;

namespace StrangeTest.Common
{
	public class NewGame : Command
	{
		public override void Execute ()
		{
			Application.LoadLevel(Levels.GAME);
		}
	}
}

