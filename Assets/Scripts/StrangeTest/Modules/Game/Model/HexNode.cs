using System;
using UnityEngine;
using System.Collections.Generic;

namespace StrangeTest.Modules.Game
{
	public class HexNode
	{
		public Vector3 Coordinates = Vector3.zero;
		public List<HexNode> Neighbours = null;
		public Hexagon view = null;

		public HexNode(Vector3 coordinates)
		{
			// :: WARNING:: Key-matchaing a 0-length vector against another 0-length
			//              vector does not work unless matching against Vector3.zero.
			//				Any explanation appreciated!
			if (coordinates == Vector3.zero)
			{
				return;
			}

			Coordinates = coordinates;
		}
	}
}

