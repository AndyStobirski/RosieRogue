using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace RosieRogue
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //  Monitor user input
        KeyboardState newKeyboardState;
        KeyboardState oldKeyboardState;
        MouseState newMouseState;
        MouseState oldMouseState;
        Point mousePosUnadjusted;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            TargetElapsedTime = TimeSpan.FromSeconds(1d / 30d); //Hardcode the frame rate
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.IsFullScreen = false;
            _graphics.PreferredBackBufferWidth = 1000;
            _graphics.PreferredBackBufferHeight = 1000;
            _graphics.ApplyChanges();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            newKeyboardState = Keyboard.GetState();
            newMouseState = Mouse.GetState();
            mousePosUnadjusted = new Point((newMouseState.X - 32) / 32, (newMouseState.Y - 32) / 32);

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);

            PlayerMove();

            oldKeyboardState = newKeyboardState;
            oldMouseState = newMouseState;
        }

        /// <summary>
        /// Monitor player keypresses
        /// </summary>
        private void PlayerMove()
        {

            if (newKeyboardState.IsKeyDown(Keys.Space))
            {

            }

            if (KeypressTest(Keys.Up, Keys.NumPad8))
            {

            }

            if (KeypressTest(Keys.Down, Keys.NumPad2))
            {

            }

            if (KeypressTest(Keys.Left, Keys.NumPad4))
            {

            }

            if (KeypressTest(Keys.Right, Keys.NumPad6))
            {

            }

            if (KeypressTest(Keys.NumPad7))//top left
            {

            }

            if (KeypressTest(Keys.NumPad9))//top right
            {

            }

            if (KeypressTest(Keys.NumPad1))//bottom left
            {

            }

            if (KeypressTest(Keys.NumPad3)) //bottom right
            {

            }

        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }

        /// <summary>
        /// Test for a single keypress
        /// </summary>
        /// <param name="key">The key to be tested
        /// <returns></returns>
        private bool KeypressTest(params Keys[] pPressed)
        {
            foreach (Keys key in pPressed)
                if (newKeyboardState.IsKeyUp(key) && oldKeyboardState.IsKeyDown(key))
                {
                    return true;
                }

            return false;
        }

        private bool LMBClick()
        {
            return newMouseState.LeftButton == ButtonState.Released && oldMouseState.LeftButton == ButtonState.Pressed;
        }

    }
}
