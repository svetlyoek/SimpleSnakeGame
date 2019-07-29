namespace SimpleSnake
{
    using SimpleSnake.Core;
    using SimpleSnake.GameObjects.Models;
    using System;
    using Utilities;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();

            Wall wall = new Wall(60, 20);
            Snake snake = new Snake(wall);

            string copyRightText = "Snake game by Svetoslav Kazakov @2019";

            Console
                .SetCursorPosition(wall.LeftX - copyRightText.Length, wall.TopY + 1);
            Console.Write(copyRightText);

            var engine = new Engine(wall, snake);
            engine.Run();
        }
    }
}
