using System;
using System.Collections.Generic;

namespace StrangeTest.Modules.Game
{
	public interface IHexNodeLinker
	{
		void Link(List<HexNode> nodes, IHexGrid context);
	}
}

