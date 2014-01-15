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
			
			commandBinder.Bind<StartSignal>().To<PauseMenuStartup>().Once();

			commandBinder.Bind<ResumeGameSignal>().To<ResumeGame>();
			commandBinder.Bind<ReturnToMainMenuSignal>().To<ReturnToMainMenu>();
			
			mediationBinder.Bind<PauseMenuView>().To<PauseMenuMediator>();
		}
	}
}