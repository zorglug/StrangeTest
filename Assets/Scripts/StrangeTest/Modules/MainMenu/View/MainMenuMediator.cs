using strange.extensions.mediation.impl;
using UnityEngine;

namespace StrangeTest.Modules.MainMenu
{
	public class MainMenuMediator : Mediator
	{
		[Inject]
		public MainMenuView View { get; set; }

		public override void OnRegister ()
		{
			base.OnRegister ();

			View.NewPressed.AddListener(OnNewPressed);
			View.LoadPressed.AddListener(OnLoadPressed);
			View.QuitPressed.AddListener(OnQuitPressed);
		}

		private void OnNewPressed()
		{
			Debug.Log("MainMenuMediator.OnNewPressed");
		}

		private void OnLoadPressed()
		{
			Debug.Log("MainMenuMediator.OnLoadPressed");
		}

		private void OnQuitPressed()
		{
			Debug.Log("MainMenuMediator.OnQuitPressed");
		}
	}
}

