using strange.extensions.command.impl;
using UnityEngine;

namespace StrangeTest.Common
{
	public class LoadGame : Command
	{
		[Inject]
		public string LevelName { get; set; }

		public override void Execute ()
		{
			Debug.Log("LoadGame command called! Level : " + LevelName);
		}
	}
}

