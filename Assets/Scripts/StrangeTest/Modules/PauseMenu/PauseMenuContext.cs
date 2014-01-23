using UnityEngine;
using StrangeTest.Common;

namespace StrangeTest.Modules.PauseMenu
{
	public class PauseMenuContext : StrangeTestModuleContext
	{
		public PauseMenuContext (MonoBehaviour contextView) : base (contextView)
		{
		}
		
		protected override void mapBindings ()
		{
			base.mapBindings ();

			injectionBinder.Bind<Camera>().To(CameraUtils.GetCameraByName(CameraNames.PAUSE_MENU_CAMERA)).ToName(CameraNames.PAUSE_MENU_CAMERA);
			
			commandBinder.Bind<StartSignal>().To<PauseMenuStartup>().Once();

			commandBinder.Bind<ResumeGameSignal>().To<ResumeGame>();
			commandBinder.Bind<ReturnToMainMenuSignal>().To<ReturnToMainMenu>();
			
			mediationBinder.Bind<PauseMenuView>().To<PauseMenuMediator>();
		}
	}
}