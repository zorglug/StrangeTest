using System;
using UnityEngine;

namespace StrangeTest.Modules.Game
{
	public interface IHexGrid
	{
		HexNode GetHexNodeAtCoordinates(float x, float y, float z);
		HexNode GetHexNodeAtCoordinates(Vector3 coords);
	}
}

