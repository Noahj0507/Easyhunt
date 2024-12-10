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
    internal class Player : Actor
    {
        private bool isDead = false;
        
        public bool IsDead
        { 
            get 
            {
                return isDead; 
            } 
        
        }
        
        private float speed =400;

        public override void Update(GameTime gameTime)
        {
            if (IsDead)
            {
                return;
            }
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            // Move the turtle based on input
            var keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Left))
            {
                IsFlippedHorizontally = false;
                X -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
            else if (keyboardState.IsKeyDown(Keys.Right))
            {
                IsFlippedHorizontally = true;
                X += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;

            }
            else if (keyboardState.IsKeyDown(Keys.Up))
            {

                Y -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
            else if (keyboardState.IsKeyDown(Keys.Down))
            {

                Y += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;

            }

            if (IsTouching(typeof(Enemy)))
            {
                World.ShowText("Game over",World.Width/2,World.Height/2);
                isDead = true; 
            }


        }
    }
}


