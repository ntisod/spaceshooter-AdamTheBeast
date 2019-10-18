using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace SpaceShooter
{
    class GameObject
    {
        protected Texture2D texture; // Rymdskeppets textur
        protected Vector2 vector; // Rymdskeppets koordinater

        public GameObject(Texture2D texture, float X, float Y)
        {
            this.texture = texture;
            this.vector.X = X;
            this.vector.Y = Y;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, vector, Color.White);
        }

        // Egenskaper för GameObject

        public float X { get { return vector.X; } }
        public float Y { get { return vector.Y; } }
        public float Width { get { return texture.Width; } }
        public float Height { get { return texture.Height; } }


    }


    abstract class MovingObject : GameObject
    {
        protected Vector2 speed; // Hastigheten på objektet
        public MovingObject(Texture2D texture, float X, float Y, float speedX, float speedY) :
        base(texture, X, Y)

        {
            this.speed.X = speedX;
            this.speed.Y = speedY;
        }
    }

}
       
           
       




  


