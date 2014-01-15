using strange.extensions.mediation.impl;
using UnityEngine;
using StrangeTest.Common;

namespace StrangeTest.Modules.MainMenu
{
	public class MainMenuMediator : Mediator
	{
		[Inject]
		public MainMenuView view { get; set; }

		[Inject]
		public NewGameSignal newGameSignal { get; set; }

		[Inject]
		public LoadGameSignal loadGameSignal { get; set; }

		[Inject]
		public QuitGameSignal quitGameSignal { get; set; }

		public override void OnRegister ()
		{
			base.OnRegister ();

			view.NewPressed.AddListener(OnNewPressed);
			view.LoadPressed.AddListener(OnLoadPressed);
			view.QuitPressed.AddListener(OnQuitPressed);
		}

		private void OnNewPressed()
		{
			newGameSignal.Dispatch();
		}

		private void OnLoadPressed()
		{
			loadGameSignal.Dispatch("Default");
		}

		private void OnQuitPressed()
		{
			quitGameSignal.Dispatch();
		}
	}
}

