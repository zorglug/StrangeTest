using strange.extensions.command.impl;
using UnityEngine;

namespace StrangeTest.Modules.Main.Controller
{
	public class MainStartup : Command
	{
		override public void Execute()
		{
			Debug.Log("Main Startup Called.");
		}
	}
}