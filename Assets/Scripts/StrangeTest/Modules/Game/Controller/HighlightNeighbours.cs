using System;
using strange.extensions.command.impl;

namespace StrangeTest.Modules.Game
{
	public class HighlightNeighbours : Command
	{
		[Inject]
		public HexNode targetNode { get; set; }

		public override void Execute ()
		{
			targetNode.view.HighLight();

			foreach (HexNode node in targetNode.Neighbours)
			{
				if (node != null)
				{
					node.view.HighLight();
				}
			}
		}
	}
}

