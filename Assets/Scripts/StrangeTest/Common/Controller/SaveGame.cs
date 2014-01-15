using strange.extensions.command.impl;
using UnityEngine;

namespace StrangeTest.Common
{
	public class SaveGame : Command
	{
		public override void Execute ()
		{
			Debug.Log("SaveGame called!");
		}
	}
}

