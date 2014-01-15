using strange.extensions.signal.impl;

namespace StrangeTest.Common
{
	public class NewGameSignal 	: Signal { }
	public class LoadGameSignal : Signal<string> { }
	public class QuitGameSignal	: Signal { }
}

