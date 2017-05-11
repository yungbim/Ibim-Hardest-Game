using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace ibimhardestgamewaw
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Map mapuno;
        Texture2D mapdos;
        Texture2D maptres;
        Texture2D mapquatro;
        Texture2D mapcinco;
        Texture2D pixelimage;
        Pixel pixel;
        List<Obstacle> Obstacles = new List<Obstacle>();
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.5
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            IsMouseVisible = true;
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            mapuno = new Map(Content.Load<Texture2D>("mapuno"), Vector2.Zero, Color.White, 1);
            mapdos = Content.Load<Texture2D>("mapdos");
            maptres = Content.Load<Texture2D>("maptres");
            mapquatro = Content.Load<Texture2D>("mapquatro");
            mapcinco = Content.Load<Texture2D>("mapsinco");
            pixelimage = Content.Load<Texture2D>("pixel");
            pixel = new Pixel(pixelimage, Vector2.One, Vector2.One, Color.Black);
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here
            KeyboardState keyboard = Keyboard.GetState();
            for (int i = 0; i < Obstacles.Count; i++)
            {
                if (pixel.HitBox.Intersects(Obstacles[i].Hitbox))
                {
                    pixel.Position = Vector2.One;
                }
            }
            pixel.Update(keyboard);
            //Color floorColor = mapuno.GetData<Color>()
            
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            spriteBatch.Draw(mapuno.Image, Vector2.Zero, Color.White);
            pixel.Draw(spriteBatch);
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
