using System;
using strange.extensions.signal.impl;

namespace StrangeTest.Modules.Game
{
	public class ShowPauseMenuSignal : Signal { }
	public class ClearAllHighlightsSignal : Signal { }
	public class HighlightNeighboursSignal : Signal<HexNode> { }
}

