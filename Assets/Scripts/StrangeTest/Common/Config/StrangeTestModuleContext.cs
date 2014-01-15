using strange.extensions.context.impl;
using strange.extensions.command.api;
using strange.extensions.command.impl;
using UnityEngine;

namespace StrangeTest.Common
{
	public class StrangeTestModuleContext : MVCSContext
	{
		public StrangeTestModuleContext (MonoBehaviour contextView) : base(contextView)
		{
		}

		public override void Launch ()
		{
			base.Launch ();

			StartSignal startSignal = injectionBinder.GetInstance<StartSignal>();
			startSignal.Dispatch();
		}

		protected override void addCoreComponents ()
		{
			base.addCoreComponents ();

			injectionBinder.Unbind<ICommandBinder>();
			injectionBinder.Bind<ICommandBinder>().To<SignalCommandBinder>().ToSingleton();
		}

		protected override void mapBindings ()
		{
			base.mapBindings ();

			implicitBinder.ScanForAnnotatedClasses (new string[]{"StrangeTest"});

			if (Context.firstContext == this)
			{
				//TODO: Map cross context stuff here.

				injectionBinder.Bind<NewGameSignal>().ToSingleton().CrossContext();
				injectionBinder.Bind<LoadGameSignal>().ToSingleton().CrossContext();
				injectionBinder.Bind<QuitGameSignal>().ToSingleton().CrossContext();

				commandBinder.Bind<NewGameSignal>().To<NewGame>();
				commandBinder.Bind<LoadGameSignal>().To<LoadGame>();
				commandBinder.Bind<QuitGameSignal>().To<QuitGame>();
			}
		}
	}
}