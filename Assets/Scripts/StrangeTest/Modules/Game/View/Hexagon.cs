using UnityEngine;
using System.Collections;
using strange.extensions.signal.impl;

namespace StrangeTest.Modules.Game
{
	public class Hexagon : MonoBehaviour
	{
		public Signal<Vector3> HexagonSelected = new Signal<Vector3>();

		public Vector2 PixelDimensions;
		public SpriteRenderer spriteRenderer;
		public float pixelsPerUnit = 100.0f; //100 is default Unity value.

		[HideInInspector]
		public Vector3 coords = new Vector3();

		private Color _color;

		void Start ()
		{
			SetRandomColor();
			LowLight();
		}

		public void HighLight()
		{
			spriteRenderer.color = Color.white;
		}

		public void LowLight()
		{
			spriteRenderer.color = _color;
		}

		void SetRandomColor()
		{
			float rand = Random.value * 3.0f;

			if (rand < 1f)
			{
				_color = Color.red;
			}
			else if (rand < 2f)
			{
				_color = Color.green;
			}
			else
			{
				_color = Color.blue;
			}
		}

		void OnMouseDown()
		{
			HexagonSelected.Dispatch(coords);
		}
	}
}