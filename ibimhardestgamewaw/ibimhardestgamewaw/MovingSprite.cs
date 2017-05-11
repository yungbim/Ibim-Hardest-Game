using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ibimhardestgamewaw
{
    class MovingSprite : Sprite
    {
        protected Vector2 _speed;
        public MovingSprite(Texture2D image, Vector2 position,Vector2 speed, Color color)
            : base(image,position,color)
        {
            _speed = speed;
        }
    }
}
