using System;
using UnityEngine;
using System.Collections.Generic;

namespace StrangeTest.Modules.Game
{
	public class HexGrid
	{
		private int _width;
		public int Width { get { return _width; } }

		private int _height;
		public int Height { get { return _height; } }

		private HexGridType _type;
		public HexGridType Type { get { return _type; } }

		private IHexCoordinatesConverter _coordConverter;

		public HexGrid(int width, int height)
		{
			Initialize(width, height, HexGridType.EvenQ);
		}

		public HexGrid(int width, int height, HexGridType type)
		{
			Initialize(width, height, type);
		}

		private void Initialize(int width, int height, HexGridType type)
		{
			_width = width;
			_height = height;
			_type = type;
			
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

		void ConstructGrid ()
		{
			//TODO: Implement construction based on type
		}
	}
}

