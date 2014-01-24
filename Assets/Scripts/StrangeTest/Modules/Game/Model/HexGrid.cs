using System;
using UnityEngine;
using System.Collections.Generic;

namespace StrangeTest.Modules.Game
{
	public class HexGrid : IHexGrid
	{
		public const HexGridType DEFAULT_TYPE = HexGridType.EvenQ;

		private int _width;
		public int Width { get { return _width; } }

		private int _height;
		public int Height { get { return _height; } }

		private HexGridType _type;
		public HexGridType Type { get { return _type; } }

		private List<HexNode> _nodes;
		public List<HexNode> Nodes
		{
			get { return _nodes; }
		}

		private Dictionary<Vector3, HexNode> _nodeLookup;
		private IHexCoordinatesConverter _coordConverter;

		public HexGrid(int width, int height)
		{
			Initialize(width, height, DEFAULT_TYPE);
		}

		public HexGrid(int width, int height, HexGridType type)
		{
			Initialize(width, height, type);
		}

		public HexNode GetHexNodeAtCoordinates(float x, float y, float z)
		{
			return GetHexNodeAtCoordinates(new Vector3(x, y, z));
		}

		public HexNode GetHexNodeAtCoordinates(Vector3 coords)
		{
			if (_nodeLookup.ContainsKey(coords))
			{
				return _nodeLookup[coords];
			}

			return null;
		}

		private void Initialize(int width, int height, HexGridType type)
		{
			_width = width;
			_height = height;
			_type = type;

			_nodes = new List<HexNode>(_width * _height);
			_nodeLookup = new Dictionary<Vector3, HexNode>(_width * _height);

			SelectConverter();
			ConstructGrid();
		}

		void SelectConverter ()
		{
			switch (_type)
			{
				case HexGridType.EvenQ:
				{
					_coordConverter = new EvenQConverter();
					break;
				}
				case HexGridType.EvenR:
				{
					_coordConverter = new EvenRConverter();
					break;
				}
				case HexGridType.OddQ:
				{
					_coordConverter = new OddQConverter();
					break;
				}
				case HexGridType.OddR:
				{
					_coordConverter = new OddRConverter();
					break;
				}
			}
		}

		void ConstructGrid()
		{
			CreateNodes();
			LinkNodes();
		}

		void CreateNodes()
		{
			HexNode node;
			
			for (int y = 0; y < _height; ++y)
			{
				for (int x = 0; x < _width; ++x)
				{
					node = new HexNode(_coordConverter.OffsetToCube(new Vector2(x, y)));
					
					_nodes.Add(node);
					_nodeLookup.Add(node.Coordinates, node);
				}
			}
		}

		void LinkNodes()
		{
			List<Vector3> neighbourOffsets = new List<Vector3>
			{
				new Vector3(0, 1, -1), new Vector3(1, 0, -1), new Vector3(1, -1, 0),
				new Vector3(0, -1, 1), new Vector3(-1, 0, 1), new Vector3(-1, 1, 0)
			};

			List<HexNode> neighbours;
			Vector3 offset;

			foreach (HexNode node in _nodes)
			{
				neighbours = new List<HexNode>(6);

				for (int i = 0; i < 6; ++i)
				{
					offset = neighbourOffsets[i];
					neighbours.Add(GetHexNodeAtCoordinates(node.Coordinates.x + offset.x, node.Coordinates.y + offset.y, node.Coordinates.z + offset.z));
				}

				node.Neighbours = neighbours;
			}
		}
	}
}

