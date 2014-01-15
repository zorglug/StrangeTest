using strange.extensions.context.impl;

namespace StrangeTest.Modules.PauseMenu
{
	public class PauseMenuRoot : ContextView
	{
		void Awake()
		{
			context = new PauseMenuContext(this);
		}
	}
}