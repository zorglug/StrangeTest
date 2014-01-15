using strange.extensions.context.impl;

namespace StrangeTest.Modules.Main
{
	public class MainRoot : ContextView
	{
		void Awake()
		{
			DontDestroyOnLoad(gameObject);
			context = new MainContext(this);
		}
	}
}