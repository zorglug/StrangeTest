using System;
using strange.extensions.mediation.impl;

namespace StrangeTest.Modules.Game
{
	public class GameContainerMediator : Mediator
	{
		[Inject]
		public GameContainerView view { get; set; }

		[Inject]
		public ShowPauseMenuSignal showPauseMenuSignal { get; set; }

		public override void OnRegister ()
		{
			view.PausePressed.AddListener(OnPause);
		}

		private void OnPause()
		{
			showPauseMenuSignal.Dispatch();
		}
	}
}

