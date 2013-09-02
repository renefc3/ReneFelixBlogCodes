using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.OCP
{
    public class DrawingShapesWithoutOcp
    {
        public static void DrawShape(string shape)
        {
            switch (shape)
            {
                case "square":
                    Console.WriteLine("SQUARE");
                    Console.WriteLine(" -----------");
                    Console.WriteLine("|           |");
                    Console.WriteLine("|           |");
                    Console.WriteLine("|           |");
                    Console.WriteLine("|           |");
                    Console.WriteLine(" -----------");
                    break;

                case "rectangle":
                    Console.WriteLine("RETANGLE");
                    Console.WriteLine("     -------------");
                    Console.WriteLine("    /              \\");
                    Console.WriteLine("  /                  \\");
                    Console.WriteLine("/                      \\");
                    Console.WriteLine("------------------------");
                    break;
            }
        }
    }
}
