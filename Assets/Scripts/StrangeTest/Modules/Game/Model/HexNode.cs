using System;
using UnityEngine;
using System.Collections.Generic;

namespace StrangeTest.Modules.Game
{
	public class HexNode
	{
		public Vector3 Coordinates;

		// Named to be orientation agnostic
		public HexNode Neighbour1 = null;
		public HexNode Neighbour2 = null;
		public HexNode Neighbour3 = null;
		public HexNode Neighbour4 = null;
		public HexNode Neighbour5 = null;
		public HexNode Neighbour6 = null;

		List<HexNode> Neighbours
		{
			get
			{ 
				return new List<HexNode> 
				{
					Neighbour1, Neighbour2, Neighbour3,
					Neighbour4, Neighbour5, Neighbour6
				};
			}
		}

		public HexNode()
		{
			Coordinates = Vector3.zero;
		}

		public HexNode(Vector3 coordinates)
		{
			Coordinates = coordinates;
		}
	}
}

