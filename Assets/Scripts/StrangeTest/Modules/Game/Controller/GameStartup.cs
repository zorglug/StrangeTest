using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

namespace StrangeTest.Modules.Game
{
	public class GameStartup : Command
	{
		[Inject]
		public IGameModel gameModel { get; set; }

		public override void Execute ()
		{
			Debug.Log("GameStartup called.");

			// Creating a mock game model for now
			gameModel.Grid = new HexGrid(7, 5, HexGridType.OddQ);
		}
	}
}