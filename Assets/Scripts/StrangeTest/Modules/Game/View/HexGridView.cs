using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;

namespace StrangeTest.Modules.Game
{
	public class HexGridView : View
	{
		public Hexagon hexagonPrefab;

		[HideInInspector]
		public Camera gameCamera {get; set;}

		public Signal<Vector3> HexagonSelected = new Signal<Vector3>();

		private List<GameObject> _hexagons;
		private IHexGrid _grid;

		public void Initialize(IHexGrid grid)
		{
			_grid = grid;
			LayoutGrid();
		}

		void LayoutGrid()
		{
			GameObject gridHolder = new GameObject("GridHolder");
			gridHolder.transform.parent = transform;

			_hexagons = new List<GameObject>(_grid.Width * _grid.Height);

			Hexagon hex;
			float hexWidth = 0.0f;
			float hexHeight = 0.0f;

			float hOffset;
			float vOffset;

			HexNode node;

			for (int y = 0; y < _grid.Height; ++y)
			{
				for (int x = 0; x < _grid.Width; ++x)
				{
					hex = (Hexagon) Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
					hexWidth = hex.PixelDimensions.x / hex.pixelsPerUnit;
					hexHeight = hex.PixelDimensions.y / hex.pixelsPerUnit;

					// :: NOTE :: These 2 lines normally depend on the grid type.
					// The currently hardcoded setup is for a grid of type Odd-Q.
					hOffset = hexWidth / 4.0f * x;
					vOffset = (x & 1) * hexHeight / 2.0f;

					hex.gameObject.transform.position = new Vector3(hexWidth * x - hOffset, hexHeight * y + vOffset, 0.0f);

					hex.gameObject.transform.parent = gridHolder.transform;

					node = _grid.Nodes[y * _grid.Width + x];

					node.view = hex;
					hex.coords = node.Coordinates;
					hex.HexagonSelected.AddListener(OnHexagonSelected);

					_hexagons.Add(hex.gameObject);
				}
			}

			float gridWidth = (hexWidth / 2.0f * _grid.Width) + (hexWidth / 4 * (_grid.Width - 1));
			float gridHeight = hexHeight * _grid.Height + hexHeight / 2f;

			gridHolder.transform.Translate(gridWidth / 2.0f * -1.0f, gridHeight / 2.0f * -1.0f + hexHeight / 2f, 0.0f);
		}

		void OnHexagonSelected(Vector3 coords)
		{
			HexagonSelected.Dispatch(coords);
		}


		// DEBUG
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
	}
}
