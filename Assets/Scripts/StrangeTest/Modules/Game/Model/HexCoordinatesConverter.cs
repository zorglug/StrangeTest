using UnityEngine;

namespace StrangeTest.Modules.Game
{
	#region Even-Q
	public class EvenQConverter : IHexCoordinatesConverter
	{
		public Vector2 CubeToOffset(Vector3 cubeCoords)
		{
			float x = cubeCoords.x;
			float y = cubeCoords.y + (cubeCoords.x + ((int)cubeCoords.x & 1)) / 2f;
			return new Vector2(x, y);
		}
		
		public Vector3 OffsetToCube(Vector2 offsetCoords)
		{
			float x = offsetCoords.x;
			float y = offsetCoords.y - (offsetCoords.x + ((int)offsetCoords.x & 1)) / 2f;
			float z = -x - y;
			return new Vector3(x, y, z);
		}
	}
	#endregion

	#region Even-R
	public class EvenRConverter : IHexCoordinatesConverter
	{
		public Vector2 CubeToOffset(Vector3 cubeCoords)
		{
			float x = cubeCoords.x + (cubeCoords.y + ((int)cubeCoords.y & 1)) / 2f;
			float y = cubeCoords.y;
			return new Vector2(x, y);
		}
		
		public Vector3 OffsetToCube(Vector2 offsetCoords)
		{
			float x = offsetCoords.x - (offsetCoords.y + ((int)offsetCoords.y & 1)) / 2f;
			float y = offsetCoords.y;
			float z = -x - y;
			return new Vector3(x, y, z);
		}
	}
	#endregion

	#region Odd-Q
	public class OddQConverter : IHexCoordinatesConverter
	{
		public Vector2 CubeToOffset(Vector3 cubeCoords)
		{
			float x = cubeCoords.x;
			float y = cubeCoords.y + (cubeCoords.x - ((int)cubeCoords.x & 1)) / 2f;
			return new Vector2(x, y);
		}
		
		public Vector3 OffsetToCube(Vector2 offsetCoords)
		{
			float x = offsetCoords.x;
			float y = offsetCoords.y - (offsetCoords.x - ((int)offsetCoords.x & 1)) / 2f;
			float z = -x - y;
			return new Vector3(x, y, z);
		}
	}
	#endregion

	#region Odd-R
	public class OddRConverter : IHexCoordinatesConverter
	{
		public Vector2 CubeToOffset(Vector3 cubeCoords)
		{
			float x = cubeCoords.x + (cubeCoords.y - ((int)cubeCoords.y & 1)) / 2f;
			float y = cubeCoords.y;
			return new Vector2(x, y);
		}
		
		public Vector3 OffsetToCube(Vector2 offsetCoords)
		{
			float x = offsetCoords.x - (offsetCoords.y - ((int)offsetCoords.y & 1)) / 2f;
			float y = offsetCoords.y;
			float z = -x - y;
			return new Vector3(x, y, z);
		}
	}
	#endregion
}
