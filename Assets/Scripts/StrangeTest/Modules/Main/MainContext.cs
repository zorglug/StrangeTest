using strange.extensions.context.impl;
using StrangeTest.Common;
using UnityEngine;


namespace StrangeTest.Modules.Main
{
	/**
	 * MainContext is the root of all contexts. It never gets unloaded.
	 */
	public class MainContext : StrangeTestModuleContext
	{
		public MainContext (MonoBehaviour contextView) : base (contextView)
		{
		}

		protected override void mapBindings ()
		{
			base.mapBindings ();

			commandBinder.Bind<StartSignal>().To<MainStartup>().Once();
		}
	}
}
