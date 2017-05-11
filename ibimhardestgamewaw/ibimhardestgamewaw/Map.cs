using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ibimhardestgamewaw
{
    class Map : Sprite
    {
        List<Rectangle> areas;
       
        public Map(Texture2D map,Vector2 position, Color color, int mapNumber)
            :base(map,position,color)
        {
            if (mapNumber == 1)
            {
                areas.Add(new Rectangle(0,0,115, map.Height));
            }
            if(mapNumber == 2)
            {
                areas.Add(new Rectangle(0, 0, 0, 0));
            }
            if(mapNumber == 3)
            {
                areas.Add(new Rectangle(0, 0, 0, 0));
            }
            if(mapNumber == 4)
            {
                
            }
            if(mapNumber == 5)
            {

            }


        }
        public void Update()
        {
            
        }
    }
}
