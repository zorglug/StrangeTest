using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

namespace StrangeTest.Modules.Game
{
	public class GameStartup : Command
	{
		public override void Execute ()
		{
			Debug.Log("GameStartup called.");
		}
	}
}