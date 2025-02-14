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

        Player playerRef = new Player();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            playerRef.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Green);

            // TODO: Add your drawing code here
            playerRef.Draw(gameTime);

            base.Draw(gameTime);
        }
    }

    public class Player
    {
       public void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.W) || Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                
            }
        }
        public void Draw(GameTime gameTime)
        {

        }
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
