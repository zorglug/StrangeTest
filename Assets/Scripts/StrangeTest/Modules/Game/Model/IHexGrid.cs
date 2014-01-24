using System;
using UnityEngine;
using System.Collections.Generic;

namespace StrangeTest.Modules.Game
{
	public interface IHexGrid
	{
		HexGridType Type { get; }

		List<HexNode> Nodes { get; }

		int Width { get; }
		int Height { get; }

		HexNode GetHexNodeAtCoordinates(float x, float y, float z);
		HexNode GetHexNodeAtCoordinates(Vector3 coords);
	}
}

