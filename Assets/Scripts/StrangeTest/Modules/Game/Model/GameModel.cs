using System;
using strange.extensions.signal.impl;

namespace StrangeTest.Modules.Game
{
	public class GameModel : IGameModel
	{
		private Signal _gridChangedSignal = new Signal();
		public Signal GridChanged
		{
			get { return _gridChangedSignal; }
		}

		IHexGrid _grid = null;
		public IHexGrid Grid
		{
			get { return _grid;	}
			set
			{
				_grid = value;
				_gridChangedSignal.Dispatch();
			}
		}

		public GameModel()
		{
		}

		public GameModel(IHexGrid grid)
		{
			_grid = grid;
		}
	}
}

