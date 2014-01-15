using strange.extensions.context.impl;
using StrangeTest.Common;
using UnityEngine;
using StrangeTest.Modules.Main.Controller;


namespace StrangeTest.Modules.Main
{
	public class MainContext : SignalContext
	{
		public MainContext (MonoBehaviour contextView) : base (contextView)
		{
		}

		protected override void mapBindings ()
		{
			base.mapBindings ();

			if (Context.firstContext == this)
			{
				//TODO: Map cross context stuff here.
			}

			commandBinder.Bind<StartSignal>().To<MainStartup>();
		}
	}
}
