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

        public Player(Texture2D texture; float X, float Y, float speedX, float speedY)
        {
             this.texture = texture;
             this.vector.X = X;
             this.vector.Y = Y;
             this.speed.X = speedX;
             this.speed.Y = speedY;
        }

        public void Update(GameWindow window)
        {














        }
    }
}