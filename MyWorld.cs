using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;
using Microsoft.Xna.Framework;

namespace EasyStart
{
    internal class MyWorld : World
    {
        private Player my_player;
        public MyWorld() : base(1920, 1080)
        {
            // Tile background with the file "bluerock" in the Content folder.
            BackgroundTileName = "bluerock";


            my_player = new Player();
            Add(my_player, "pikapika1", 200, 200);
            Add(new Enemy(my_player), "diglett", 1000, 500);


        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (my_player.IsDead)
            { 
                MyWorld world = new MyWorld();
                EasyGame.Instance.ActiveWorld = world;
            }
        }
    }
}
