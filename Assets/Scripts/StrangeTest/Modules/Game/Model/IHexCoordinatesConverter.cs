using System;
using UnityEngine;

namespace StrangeTest.Modules.Game
{
	public interface IHexCoordinatesConverter
	{
		Vector2 CubeToOffset(Vector3 cubeCoords);
		Vector3 OffsetToCube(Vector2 offsetCoords);
	}
}

