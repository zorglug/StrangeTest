using strange.extensions.context.impl;
using StrangeTest.Common;
using UnityEngine;

namespace StrangeTest.Modules.MainMenu
{
	public class MainMenuContext : StrangeTestModuleContext
	{
		public MainMenuContext (MonoBehaviour contextView) : base (contextView)
		{
		}
		
		protected override void mapBindings ()
		{
			base.mapBindings ();

			commandBinder.Bind<StartSignal>().To<MainMenuStartup>().Once();

			mediationBinder.Bind<MainMenuView>().To<MainMenuMediator>();
		}
	}
}