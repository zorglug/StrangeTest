using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using strange.extensions.mediation.impl;

namespace StrangeTest.Modules.Game
{
	public class HexGridView : View
	{
		public Hexagon hexagonPrefab;

		[HideInInspector]
		public Camera gameCamera {get; set;}

		private List<GameObject> _hexagons;
		
	  	protected override void Start ()
		{
			base.Start();
			LayoutGrid();
		}

		void OnGUI()
		{
			GUIStyle style = new GUIStyle();
			style.alignment = TextAnchor.MiddleCenter;
			Hexagon hex;
			foreach (GameObject hexObject in _hexagons)
			{
				hex = hexObject.GetComponent<Hexagon>();

				Vector3 point = gameCamera.WorldToScreenPoint(hexObject.transform.position);
				GUI.Label(new Rect(point.x - 50.0f, gameCamera.pixelHeight - point.y - 25.0f, 100.0f, 50.0f), 
				          string.Format("[{0}, {1}, {2}]", hex.coords.x, hex.coords.y, hex.coords.z), style);
			}
		}
		
		void LayoutGrid()
		{
			Hexagon hex;
			GameObject gridHolder = new GameObject("GridHolder");
			
			float width = 0.0f;
			float height = 0.0f;
			float hOffset = 0.0f;
			float vOffset = 0.0f;
			
			int w = 7;
			int h = 5;
			
			float gridX;
			float gridY;
			float gridZ;
			
			_hexagons = new List<GameObject>();
			
			//::NOTE:: Layout code for "Flat-Top" style hexagons, offsetting even columns
			for (int y = 0; y < h; y++)
			{
				for (int x = 0; x < w; x++)
				{
					hex = (Hexagon) Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
					
					width = hex.PixelDimensions.x / hex.pixelsPerUnit;
					height = hex.PixelDimensions.y / hex.pixelsPerUnit;
					
					vOffset = (x & 1) * height / 2.0f;
					
					hOffset = width / 4.0f * x;
					
					hex.gameObject.transform.position = new Vector3(width * x - hOffset, height * y + vOffset, 0.0f);
					
					hex.gameObject.transform.parent = gridHolder.transform;
					
					gridX = x;
					gridY = y - (int)(x / 2f);
					gridZ = -gridX - gridY;
					
					hex.coords = new Vector3(gridX, gridY, gridZ);
					
					_hexagons.Add(hex.gameObject);
				}
			}
			
			float gridWidth = (width / 2.0f * w) + (width / 4 * (w - 1));
			float gridHeight = height * h + height / 2f;
			
			gridHolder.transform.parent = transform;
			gridHolder.transform.Translate(gridWidth / 2.0f * -1.0f, gridHeight / 2.0f * -1.0f + height / 2f, 0.0f);
		}
	}
}
