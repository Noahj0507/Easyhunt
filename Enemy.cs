using EasyMonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace EasyStart
{
    internal class Enemy : Actor
    {
        private Player pikapika1;

        public Enemy(Player pikapika1)
        {
            this.pikapika1 = pikapika1;
        }

        public override void Update(GameTime gameTime)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            TurnTowards(pikapika1.X, pikapika1.Y);
            Move(200 * deltaTime);
        }




    }
}
