﻿
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace GP_Final_Catapult.GameObjects {
	class Enemy : IGameObject {
		public int hp;

		public override void Update(GameTime gameTime, List<IGameObject> gameObjects) {

			base.Update(gameTime, gameObjects);
		}
		public override void Draw(SpriteBatch spriteBatch) {

			base.Draw(spriteBatch);
		}
	}
}
