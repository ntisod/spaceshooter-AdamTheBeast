using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceShooter
{
    class Player
    {
        Texture2D texture; // Rymdskeppets texture
        Vector2 vector; // Rymdskeppets koordinater
        Vector2 speed; // Rymdskeppets hastighet

        //Player(), konstruktor för att skapa spela-objektet

        public Player(Texture2D texture, float X, float Y, float speedX, float speedY) 
        {
             this.texture = texture;
             this.vector.X = X;
             this.vector.Y = Y;
             this.speed.X = speedX;
             this.speed.Y = speedY;
        }

        public void Update(GameWindow window)
        {
        // Läs in tangenttryckningar:
        KeyboardState keyboardState = Keyboard.GetState();
        
        //Flytta rymdskeppet efter tangenttryckningar (om det
        //inte är på väg ut från kanten):

        if (vector.X <= window.ClientBounds.Width - texture.Width && vector.X >= 0)
        {
            if (keyboardState.IsKeyDown(Keys.Right))
                vector.X += speed.X;
            if (keyboardState.IsKeyDown(Keys.Left))
                vector.X -= speed.X;
        }
        if (vector.Y <= window.ClientBounds.Height - texture.Height && vector.Y >= 0)
        {
                if (keyboardState.IsKeyDown(Keys.Down))
                    vector.Y += speed.Y;

                if (keyboardState.IsKeyDown(Keys.Up))
                    vector.Y -= speed.Y;
            }

            //Kontrollera ifall rymdskeppet har åkt ut från kanten, om det har det, så återställ dess position.
            
            //Har det åkt ut till vänster:

            if (vector.X < 0)
                vector.X = 0;

            //Har det åkt till höger:

            if (vector.X > window.ClientBounds.Width - texture.Width)
                vector.X = window.ClientBounds.Width - texture.Width;



            //Har det  åkt till upptill:

            if (vector.Y < 0)
                vector.Y = 0;

            if (vector.Y > window.ClientBounds.Height - texture.Height)
            {
                vector.Y = window.ClientBounds.Height - texture.Height;
            }
        }



        //Draw(, ritar ut spelaren på skärmen
        public void Draw(SpriteBatch spriteBatch)


        {
            spriteBatch.Draw(texture, vector, Color.White);

            




        }
    }
}