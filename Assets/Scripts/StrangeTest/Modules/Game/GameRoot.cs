using UnityEngine;
using strange.extensions.context.impl;
namespace StrangeTest.Modules.Game
{
	public class GameRoot : ContextView
	{
		void Awake()
		{
			context = new GameContext(this);
		}
	}
}