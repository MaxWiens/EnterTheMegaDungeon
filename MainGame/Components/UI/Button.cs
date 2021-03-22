﻿using MoonSharp.Interpreter;
using System.Text.Json.Serialization;
using ECS;
using System;
namespace MainGame.Components.UI {
	[MoonSharpUserData]
	public class Button : Component {
		[JsonInclude] public Script ClickEvent;

		public override uint Priority => 10;
		public Button(Entity entity) : base(entity) { }

		public override IComponent Clone(Entity entity) => new Button(entity) {
				ClickEvent = ClickEvent
			};

		[MessageHandler]
		public bool OnClick(Message _) {
			ClickEvent.Call(ClickEvent.Globals["OnClick"]);
			return true;
		}
	}
}
