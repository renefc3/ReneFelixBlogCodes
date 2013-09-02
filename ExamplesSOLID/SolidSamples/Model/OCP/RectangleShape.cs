using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.OCP
{
    public class RectangleShape : IShape
    {
        public void DrawShape()
        {
            Console.WriteLine("RETANGLE");
            Console.WriteLine("     -------------");
            Console.WriteLine("    /              \\");
            Console.WriteLine("  /                  \\");
            Console.WriteLine("/                      \\");
            Console.WriteLine("------------------------");
        }
    }

}
