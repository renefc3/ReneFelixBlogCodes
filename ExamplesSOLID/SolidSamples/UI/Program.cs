using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.ISP;
using Model.LSP;
using Model.OCP;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleOfOCP();
            SampleOfISP();
            SampleOfLSP();
        }

        private static void SampleOfLSP()
        {
            Console.WriteLine("Sample of LSP");
            
            Person.PuttingOnLeftFootBreakingLSP(new RightShoe(), new RightSock());
            Person.PuttingOnRightFootBreakingLSP(new LeftShoe(), new RightSock());

            Person.PuttingOnRightFootUsingLSP(new RightShoe(), new RightSock());
            Person.PuttingOnLeftFootUsingLSP(new LeftShoe(), new RightSock());

            Console.ReadKey();
        }

        private static void SampleOfISP()
        {
            ////this is the danger of not following this principle
            //IVehicleBreakingISP harley = new MotorcycleBreakingISP();
            //harley.OpenDoor();

            Console.WriteLine("Sample of ISP");
            IVehicle vehicle = new Car();
            vehicle.TurnOn();
            vehicle.TurnOff();
            Console.WriteLine("Press Any key to Contunue the sample of OCP");
            Console.ReadKey();

            vehicle = new Motorcycle();
            vehicle.TurnOn();
            vehicle.TurnOff();

            Console.ReadKey();

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
