using System;

namespace Model.OCP
{
    public class SquareShape : IShape
    {
        public void DrawShape()
        {
            Console.WriteLine("SQUARE");
            Console.WriteLine(" -----------");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine(" -----------");
        }
    }
}