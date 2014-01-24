using System;
using strange.extensions.mediation.impl;
using UnityEngine;
using StrangeTest.Common;

namespace StrangeTest.Modules.Game
{
	public class HexGridMediator : Mediator
	{
		[Inject]
		public HexGridView view { get; set; }

		[Inject]
		public IGameModel gameModel { get; set; }

		[Inject]
		public HighlightNeighboursSignal highlightNeighboursSignal { get; set; }

		[Inject]
		public ClearAllHighlightsSignal clearAllHighlightsSignal { get; set; }

		[Inject (CameraNames.GAME_CAMERA)]
		public Camera gameCamera { get; set; }

		public override void OnRegister ()
		{
			view.gameCamera = gameCamera;

			view.HexagonSelected.AddListener(OnHexagonSelected);

			if (gameModel.Grid != null)
			{
				InitView();
			}
			else
			{
				gameModel.GridChanged.AddOnce(InitView);
			}
		}

		private void InitView()
		{
			view.Initialize(gameModel.Grid);
		}

		private void OnHexagonSelected(Vector3 coords)
		{
			clearAllHighlightsSignal.Dispatch();
			highlightNeighboursSignal.Dispatch(gameModel.Grid.GetHexNodeAtCoordinates(coords));
		}
	}
}

