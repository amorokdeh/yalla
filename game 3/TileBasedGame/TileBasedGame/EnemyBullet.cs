﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileBasedGame
{
    class EnemyBullet : GameObject
    {
        public GameObject GameObject;

        public string Name;

        public EnemyBullet(string name, GameObject enemy, int w, int h) : base(name, w, h)
        {
            GameObject = enemy;
            this.Name = name;

            Pause = 0;

            //VelY = -10;
            VelY = 200;
            Img = Program.Game.loader.enemyBulletImg;

        }

        public override void ChangeImage()
        {

            base.ChangeImage(3);
        }
    }
}
