namespace SimpleSnake.GameObjects.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public interface IPoint
    {
        int LeftX { get; }

        int TopY { get; }

        void Draw(char symbol);

        void Draw(int leftX, int topY, char symbol);

    }
}
