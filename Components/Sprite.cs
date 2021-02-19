﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Text.Json.Serialization;
namespace MainGame.Components {
	public struct Sprite {
		public Texture2D Texture;
		[JsonInclude] public Vector2 Offset;
		[JsonInclude] public string TextureName;
		[JsonInclude] public Color Albedo;
		[JsonInclude] public Vector2 Scale;
	}
}
