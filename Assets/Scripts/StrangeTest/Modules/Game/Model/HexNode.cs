using System;
using UnityEngine;
using System.Collections.Generic;

namespace StrangeTest.Modules.Game
{
	public class HexNode
	{
		public Vector3 Coordinates = Vector3.zero;
		public List<HexNode> Neighbours = null;

		public HexNode()
		{
		}

		public HexNode(Vector3 coordinates)
		{
			Coordinates = coordinates;
		}

		public HexNode(Vector3 coordinates, List<HexNode> neighbours)
		{
			Coordinates = coordinates;
			Neighbours = neighbours;
		}
	}
}

