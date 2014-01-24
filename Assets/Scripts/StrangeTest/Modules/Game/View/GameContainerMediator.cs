using strange.extensions.mediation.impl;
using UnityEngine;

namespace StrangeTest.Modules.Game
{
	public class GameContainerMediator : Mediator
	{
		[Inject]
		public GameContainerView view { get; set; }

		[Inject]
		public ShowPauseMenuSignal showPauseMenuSignal { get; set; }

		[Inject]
		public IGameModel gameModel { get; set; }

		[Inject]
		public ClearAllHighlightsSignal clearAllHighlightsSignal { get; set; }

		[Inject]
		public HighlightNeighboursSignal highlightNeighboursSignal { get; set; }


		public override void OnRegister ()
		{
			view.PausePressed.AddListener(OnPause);
			view.RandomNodePressed.AddListener(OnRandomNodePressed);
		}

		private void OnPause()
		{
			showPauseMenuSignal.Dispatch();
		}

		private void OnRandomNodePressed()
		{
			print ("Random Node pressed");

			clearAllHighlightsSignal.Dispatch();

			IHexCoordinatesConverter coordConverter = null;
			switch (gameModel.Grid.Type)
			{
				case HexGridType.EvenQ:
				{
					coordConverter = new EvenQConverter();
					break;
				}
				case HexGridType.EvenR:
				{
					coordConverter = new EvenRConverter();
					break;
				}
				case HexGridType.OddQ:
				{
					coordConverter = new OddQConverter();
					break;
				}
				case HexGridType.OddR:
				{
					coordConverter = new OddRConverter();
					break;
				}
			}

			int randX = Random.Range(0, gameModel.Grid.Width);
			int randY = Random.Range(0, gameModel.Grid.Height);

			HexNode randomNode = gameModel.Grid.GetHexNodeAtCoordinates(coordConverter.OffsetToCube(new Vector2(randX, randY)));

			highlightNeighboursSignal.Dispatch(randomNode);
		}
	}
}

