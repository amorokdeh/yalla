﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileBasedGame
{
    class PhysicsComponent : Component
    {
        PhysicsManager PhysicsManager;
        public PhysicsComponent(PhysicsManager pm):base()
        {
            this.PhysicsManager = pm;
        }

        

        public virtual void Move(float deltaT)
        {

            GameObject.PosX += GameObject.CurrentVelX * deltaT;
            GameObject.PosY += GameObject.CurrentVelY * deltaT;   

        }

        public void CheckBorders()
        {
            int mapWidth = Program.Game._maps.currentMap.mapWidth;
            int mapHeight = Program.Game._maps.currentMap.mapHeight;

            if (GameObject.PosX < 0)
            {
                GameObject.PosX = 0;

            } else if(GameObject.PosX > mapWidth - GameObject.Width)
            {
                GameObject.PosX = mapWidth - GameObject.Width;
            }
            if (GameObject.PosY < 0)
            {
                GameObject.PosY = 0;
            }
            else if (GameObject.PosY > mapHeight - GameObject.Height)
            {
                GameObject.PosY = mapHeight - GameObject.Height;
            }


        }
    }
}
