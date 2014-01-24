using System;
using UnityEngine;
using System.Collections.Generic;

namespace StrangeTest.Modules.Game
{
	public class HexNode
	{
		Vector3 _coordinates;
		Vector3 Coordinates
		{
			get { return _coordinates; }
		}

		List<HexNode> _neighbours;
		List<HexNode> Neighbours
		{
			get { return _neighbours; }
		}

		public HexNode(Vector3 coordinates, List<HexNode> neighbours)
		{
			if (neighbours.Count != 6)
			{
				throw new ArgumentException(string.Format("An HexNode can only have 6 neighbours. Received a list of neighbours with {0} entries.", neighbours.Count));
			}

			_coordinates = coordinates;
			_neighbours = neighbours;
		}
	}
}

