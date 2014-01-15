using strange.extensions.command.impl;
using UnityEngine;
using StrangeTest.Common;

namespace StrangeTest.Modules.Main
{
	public class MainStartup : Command
	{
		override public void Execute()
		{
			Debug.Log("Main Startup Called!");
			Application.LoadLevel(Levels.MAIN_MENU);
		}
	}
}