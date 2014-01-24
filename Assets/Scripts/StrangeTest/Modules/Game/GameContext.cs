using UnityEngine;
using System.Collections;
using StrangeTest.Common;

namespace StrangeTest.Modules.Game
{
	public class GameContext : StrangeTestModuleContext
	{
		public GameContext (MonoBehaviour contextView) : base (contextView)
		{
		}
		
		protected override void mapBindings ()
		{
			base.mapBindings ();

			injectionBinder.Bind<IGameModel>().To<GameModel>().ToSingleton();

			injectionBinder.Bind<Camera>().To(CameraUtils.GetCameraByName(CameraNames.GAME_CAMERA)).ToName(CameraNames.GAME_CAMERA);
			
			commandBinder.Bind<StartSignal>().To<GameStartup>().Once();
			commandBinder.Bind<ShowPauseMenuSignal>().To<ShowPauseMenu>();
			commandBinder.Bind<ClearAllHighlightsSignal>().To<ClearAllHighlights>().Pooled();
			commandBinder.Bind<HighlightNeighboursSignal>().To<HighlightNeighbours>().Pooled();

			mediationBinder.Bind<GameContainerView>().To<GameContainerMediator>();
			mediationBinder.Bind<HexGridView>().To<HexGridMediator>();
		}
	}
}