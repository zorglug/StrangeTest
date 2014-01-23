using UnityEngine;
using System.Collections;

namespace StrangeTest.Modules.Game
{
	public class Hexagon : MonoBehaviour
	{
		private static Color Color1 = new Color(1f, 0f, 0f);
		private static Color Color2 = new Color(0f, 1f, 0f);
		private static Color Color3 = new Color(0f, 0f, 1f);

		public Vector2 PixelDimensions;
		public SpriteRenderer spriteRenderer;
		public float pixelsPerUnit = 100.0f; //100 is default Unity value.

		[HideInInspector]
		public Vector3 coords = new Vector3();

		void Start ()
		{
			SetRandomColor ();
		}

		void SetRandomColor()
		{
			float rand = Random.value * 3.0f;

			if (rand < 1f)
			{
				spriteRenderer.color = Color1;
			}
			else if (rand < 2f)
			{
				spriteRenderer.color = Color2;
			}
			else
			{
				spriteRenderer.color = Color3;
			}
		}
	}
}