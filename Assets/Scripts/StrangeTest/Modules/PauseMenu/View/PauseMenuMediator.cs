using strange.extensions.mediation.impl;
using StrangeTest.Common;
using UnityEngine;

namespace StrangeTest.Modules.PauseMenu
{
	public class PauseMenuMediator : Mediator
	{
		[Inject]
		public PauseMenuView view { get; set; }
		
		[Inject]
		public ResumeGameSignal resumeGameSignal { get; set; }
		
		[Inject]
		public SaveGameSignal saveGameSignal { get; set; }
		
		[Inject]
		public ReturnToMainMenuSignal returnToMainMenuSignal { get; set; }

		[Inject (CameraNames.PAUSE_MENU_CAMERA)]
		public Camera pauseCam { get; set; }
		
		public override void OnRegister ()
		{
			base.OnRegister ();

			view.pauseCam = pauseCam;
			
			view.ResumePressed.AddListener(OnResumePressed);
			view.SavePressed.AddListener(OnSavePressed);
			view.LeavePressed.AddListener(OnLeavePressed);
		}
		
		private void OnResumePressed()
		{
			resumeGameSignal.Dispatch();
		}
		
		private void OnSavePressed()
		{
			saveGameSignal.Dispatch();
		}
		
		private void OnLeavePressed()
		{
			returnToMainMenuSignal.Dispatch();
		}
	}
}