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



namespace WindowsGame1
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Loader loader = new Loader();
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        Texture2D myTexture;
        Vector2 spritePosition = Vector2.Zero ;
        Rectangle playerFrame;
        Texture2D cropTexture;
        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

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
            myTexture = loader.load(Content);
            
            playerFrame = new Rectangle(10, 10,50, 50);
            cropTexture = new Texture2D(GraphicsDevice, playerFrame.Width, playerFrame.Height);
            Color[] data = new Color[playerFrame.Width * playerFrame.Height];
            myTexture.GetData(0, playerFrame, data, 0, data.Length);
            cropTexture.SetData(data);
            spritePosition = new Vector2((graphics.GraphicsDevice.Viewport.Width - cropTexture.Width) / 2, (graphics.GraphicsDevice.Viewport.Height - cropTexture.Height) / 2);
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

        Vector2 spriteSpeed = new Vector2(50.0f, 50.0f);

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
#if WINDOWS
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                this.Exit();
#endif
            // TODO: Add your update logic here
            UpdateSprite(gameTime);

            base.Update(gameTime);
        }

        void UpdateSprite(GameTime gameTime)
        {
            
            //spritePosition += spriteSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            //int MaxX =
            //    graphics.GraphicsDevice.Viewport.Width - myTexture.Width;
            //int MinX = 0;
            //int MaxY =
            //    graphics.GraphicsDevice.Viewport.Height - myTexture.Height;
            //int MinY = 0;

            //// Check for bounce.
            //if (spritePosition.X > MaxX)
            //{
            //    spriteSpeed.X *= -1;
            //    spritePosition.X = MaxX;
            //}

            //else if (spritePosition.X < MinX)
            //{
            //    spriteSpeed.X *= -1;
            //    spritePosition.X = MinX;
            //}

            //if (spritePosition.Y > MaxY)
            //{
            //    spriteSpeed.Y *= -1;
            //    spritePosition.Y = MaxY;
            //}

            //else if (spritePosition.Y < MinY)
            //{
            //    spriteSpeed.Y *= -1;
            //    spritePosition.Y = MinY;
            //}
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Blue);

            // TODO: Add your drawing code here
            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
            spriteBatch.Draw(cropTexture, spritePosition, Color.White);
            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
