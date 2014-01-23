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

		[Inject (CameraNames.GAME_CAMERA)]
		public Camera gameCamera { get; set; }

		public override void OnRegister ()
		{
			view.gameCamera = gameCamera;
		}
	}
}

