﻿namespace SimpleSnake.GameObjects.Models
{
    using SimpleSnake.GameObjects.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Point : IPoint
    {
        public Point(int leftX, int topY)
        {
            this.LeftX = leftX;
            this.TopY = topY;
        }
        public int LeftX { get; protected set; }

        public int TopY { get; protected set; }

        public void Draw(char symbol)
        {
            Console.SetCursorPosition(this.LeftX, this.TopY);
            Console.Write(symbol);
        }

        public void Draw(int leftX, int topY, char symbol)
        {
            Console.SetCursorPosition(leftX, topY);
            Console.Write(symbol);
        }
    }
}
