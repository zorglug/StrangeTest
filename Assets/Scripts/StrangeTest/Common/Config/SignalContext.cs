using strange.extensions.context.impl;
using strange.extensions.command.api;
using strange.extensions.command.impl;
using UnityEngine;

namespace StrangeTest.Common
{
	public class SignalContext : MVCSContext
	{
		public SignalContext (MonoBehaviour contextView) : base(contextView)
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
			injectionBinder.Unbind<ICommandBinder> ();
			injectionBinder.Bind<ICommandBinder> ().To<SignalCommandBinder> ().ToSingleton ();
		}

		protected override void mapBindings ()
		{
			base.mapBindings ();
			implicitBinder.ScanForAnnotatedClasses (new string[]{"StrangeTest"});
		}
	}
}