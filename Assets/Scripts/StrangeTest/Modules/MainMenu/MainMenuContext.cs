using strange.extensions.context.impl;
using StrangeTest.Common;
using UnityEngine;

namespace StrangeTest.Modules.MainMenu
{
	public class MainMenuContext : SignalContext
	{
		public MainMenuContext (MonoBehaviour contextView) : base (contextView)
		{
		}
		
		protected override void mapBindings ()
		{
			base.mapBindings ();
			
			if (Context.firstContext == this)
			{
				//TODO: Specific mappings to run this module in isolation.
			}

			commandBinder.Bind<StartSignal>().To<MainMenuStartup>().Once();

			mediationBinder.Bind<MainMenuView>().To<MainMenuMediator>();
		}
	}
}