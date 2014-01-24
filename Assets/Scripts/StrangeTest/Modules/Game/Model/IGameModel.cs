using System;
using strange.extensions.signal.impl;

namespace StrangeTest.Modules.Game
{
	public interface IGameModel
	{
		Signal GridChanged { get; }
		IHexGrid Grid { get; set; }
	}
}

