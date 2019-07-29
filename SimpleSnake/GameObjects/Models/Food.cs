namespace SimpleSnake.GameObjects.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public abstract class Food : Point
    {
        private char foodSymbol;
        private Wall wall;
        private Random random;
        public Food(Wall wall, char foodSymbol, int points)
            : base(wall.LeftX, wall.TopY)
        {
            this.wall = wall;
            this.foodSymbol = foodSymbol;
            this.FoodPoints = points;
            this.random = new Random();
        }

        public int FoodPoints { get;  set; }

        public void SetRandomPosition(Queue<Point> snakeElements)
        {

            this.LeftX = random.Next(2, wall.LeftX - 2);
            this.TopY = random.Next(2, wall.TopY - 2);

            bool isPointOfSnake = snakeElements
                .Any(p => p.LeftX == this.LeftX && p.TopY == this.TopY);

            while (isPointOfSnake)
            {
                this.LeftX = random.Next(2, wall.LeftX - 2);
                this.TopY = random.Next(2, wall.TopY - 2);

                isPointOfSnake = snakeElements
                .Any(p => p.LeftX == this.LeftX && p.TopY == this.TopY);
            }

            Console.BackgroundColor = ConsoleColor.Red;
            this.Draw(foodSymbol);
            Console.BackgroundColor = ConsoleColor.White;

        }

        public bool IsFoodPoint(Point snake)
        {
            return snake.LeftX == this.LeftX
                && snake.TopY == this.TopY;
        }
    }
}
