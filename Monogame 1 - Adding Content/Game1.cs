using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_1___Adding_Content
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Rectangle window;

        Texture2D dinoTexture;
        Texture2D jackTexture;
        Texture2D snowTexture;
        Texture2D ceilingTexture;
        Texture2D windowTexture;
        Texture2D outsideTexture;
        Texture2D plantTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            window = new Rectangle(0, 0, 800, 500);

            //sets title of game window
            this.Window.Title = "";

            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            dinoTexture = Content.Load<Texture2D>("dino");
            jackTexture = Content.Load<Texture2D>("jack");
            snowTexture = Content.Load<Texture2D>("snowing");
            ceilingTexture = Content.Load<Texture2D>("ceiling");
            outsideTexture = Content.Load<Texture2D>("outside");
            windowTexture = Content.Load<Texture2D>("window");
            plantTexture = Content.Load<Texture2D>("plant1");
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

            _spriteBatch.Draw(dinoTexture, new Vector2(10, 10), Color.Red);
            _spriteBatch.Draw(dinoTexture, new Vector2(300, 10), Color.Purple);
            _spriteBatch.Draw(jackTexture, new Vector2(300, 10), Color.Purple);
            _spriteBatch.Draw(ceilingTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(outsideTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(snowTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(windowTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(plantTexture, new Vector2(480, 240), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
