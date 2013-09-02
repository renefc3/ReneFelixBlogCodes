using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.OCP;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleOfOCP();
        }

        private static void SampleOfOCP()
        {
            //Create shapes
            IShape rectangle = new RectangleShape();
            IShape square = new SquareShape();
            DrawingShapes d = new DrawingShapes();
            
            //add feature to draw rectangle
            d.AddShape(rectangle);
            //drawing images
            d.DrawImages();

            Console.WriteLine("Press Any key to Contunue the sample of OCP");
            Console.ReadKey();

            //add feature to draw square
            d.AddShape(square);

            //drawing images
            d.DrawImages();

            //try to implement another shape to see the important of this principle

            Console.ReadKey();



        }
    }
}
