using System;
using strange.extensions.command.impl;

namespace StrangeTest.Modules.Game
{
	public class ClearAllHighlights : Command
	{
		[Inject]
		public IGameModel gameModel { get; set; }

		public override void Execute ()
		{
			foreach (HexNode hexNode in gameModel.Grid.Nodes)
			{
				hexNode.view.LowLight();
			}
		}
	}
}

