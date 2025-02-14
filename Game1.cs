using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace MonoGameSprintProject_NathanielWhite_20250212
{
    public class Game1 : Game
    {
        /// <summary>
        /// This is the constructor for the Pipe class, it takes a reference to Game Manager
        /// So we can cache the GameManager reference.
        /// It also takes an initial position of where the pipe will be on the screen.
        /// </summary>
        /// <remarks>
        /// Pipes are cool!
        /// <remarks>
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // Reference to the texture the player will have
        private Texture2D playerTexture;

        // Reference to the position the player will have
        private Vector2 playerPosition;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // Loads in the Player_Sprite.png file from Content
            playerTexture = Content.Load<Texture2D>("Player_Sprite");

            playerPosition = Vector2.Zero;
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Moves the player when they press W (Up), A (Left), S (Down), and D (Right)
            if (Keyboard.GetState().IsKeyDown(Keys.W) || Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                playerPosition.Y -= 1f;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.S) || Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                playerPosition.Y += 1f;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.A) || Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                playerPosition.X -= 1f;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                playerPosition.X += 1f;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Green);

            // Draws the players texture and it's position
            _spriteBatch.Begin();
            _spriteBatch.Draw(playerTexture, playerPosition, Color.White);
            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }

    public class Player
    {
        
    }

    public class Tiles
    {

    }

    public class CollisionTiles : Tiles
    {

    }

    public class ExitTiles : Tiles
    {

    }
}
