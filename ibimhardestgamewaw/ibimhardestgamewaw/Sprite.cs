using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ibimhardestgamewaw
{
    class Sprite
    {
       public Texture2D Image;
       public Vector2 Position;
       public Color Color;
        public Sprite(Texture2D image,Vector2 position, Color color)
        {
            Image = image;
            Position = position;
            Color = color;
        }
    }
}
