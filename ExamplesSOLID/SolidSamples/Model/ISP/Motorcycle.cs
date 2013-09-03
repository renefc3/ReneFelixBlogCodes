using System;

namespace Model.ISP
{
    public class Motorcycle : IVehicle
    {
        public void TurnOn()
        {
            Console.WriteLine("Turn ON the Motorcycle!!!!");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turn OFF the Motorcycle!!!!");

        }

    }
}