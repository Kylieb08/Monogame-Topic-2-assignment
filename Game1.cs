﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Topic_2_assignment
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D buildingTexture, windowTexture, windowSeperatorTexture, doorTexture, doorknobTexture;
        Rectangle buildingRect, doorRect, doorknobRect;
        int windowX = 35, windowSeperatorY = 100;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            this.Window.Title = "Topic 2 Assignment";

            buildingRect = new Rectangle(20, 20, 300, 480);
            doorRect = new Rectangle(130, 350, 80, 130);
            doorknobRect = new Rectangle(195, 410, 10, 10);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            buildingTexture = Content.Load<Texture2D>("rectangle");
            windowTexture = Content.Load<Texture2D>("rectangle");
            windowSeperatorTexture = Content.Load<Texture2D>("rectangle");
            doorTexture = Content.Load<Texture2D>("rectangle");
            doorknobTexture = Content.Load<Texture2D>("circle");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(buildingTexture, buildingRect, Color.DarkGray);
            for (int i = 0; i < 3; i++)
            {
                _spriteBatch.Draw(windowTexture, new Rectangle(i * 95 + windowX, 35, 80, 400), Color.Yellow);
            }
            for (int i = 0; i < 5; i++)
            {
                _spriteBatch.Draw(windowSeperatorTexture, new Rectangle(20, i * 80 + windowSeperatorY, 300, 15), Color.DarkGray);
            }
            _spriteBatch.Draw(doorTexture, doorRect, Color.SaddleBrown);
            _spriteBatch.Draw(doorknobTexture, doorknobRect, Color.LightGoldenrodYellow);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
