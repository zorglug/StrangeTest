using strange.extensions.context.impl;

namespace StrangeTest.Modules.MainMenu
{
	public class MainMenuRoot : ContextView
	{
		void Awake()
		{
			context = new MainMenuContext(this);
		}
	}
}