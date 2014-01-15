using strange.extensions.context.impl;

namespace StrangeTest.Modules.Main
{
	public class MainRoot : ContextView
	{
		void Start()
		{
			context = new MainContext(this);
		}
	}
}