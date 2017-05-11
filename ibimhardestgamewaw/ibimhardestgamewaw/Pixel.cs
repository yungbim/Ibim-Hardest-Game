using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ibimhardestgamewaw
{
    class Pixel : MovingSprite
    {
        protected Rectangle hitBox;
        public Rectangle HitBox
        {
            get
            {
                return hitBox;
            }
            set
            {
                hitBox = value;
            }

        }
        
        public Pixel(Texture2D image,Vector2 position,Vector2 speed, Color color)
            : base (image,position,speed,color)
        {
            hitBox = new Rectangle((int)position.X, (int)position.Y, image.Width, image.Height);
        }
        public void Update(KeyboardState keyboard)
        {
           if(keyboard.IsKeyDown(Keys.W))
            {
                Position.Y -= _speed.Y; 
            }
           if(keyboard.IsKeyDown(Keys.A))
            {
                Position.X -= _speed.X;
            }
           if(keyboard.IsKeyDown(Keys.S))
            {
                Position.Y += _speed.Y;
            }
           if(keyboard.IsKeyDown(Keys.D))
            {
                Position.X += _speed.X;
            }
           
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Image, Position, Color);
        }
    }
}
