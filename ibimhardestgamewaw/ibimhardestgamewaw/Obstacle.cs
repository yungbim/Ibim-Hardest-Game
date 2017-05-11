using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ibimhardestgamewaw
{
    class Obstacle : MovingSprite
    {
        protected Rectangle hitbox;
        public Rectangle Hitbox
        {
            get
            {
                return hitbox;
            }
            set
            {
                hitbox = value;
            }
        }
        
        public Obstacle(Texture2D image, Vector2 position, Vector2 speed, Color color)
            : base(image,position,speed,color)
        {
            hitbox = new Rectangle((int)position.X, (int)position.Y, image.Width, image.Height);
        }
        public void Update()
        {
            
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Image, Position, Color);
        }
    }
}
