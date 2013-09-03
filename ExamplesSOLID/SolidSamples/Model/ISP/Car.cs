using System;

namespace Model.ISP
{
    public class Car : IVehicle, IHasDoors
    {

        public void TurnOn()
        {
            Console.WriteLine("Turn ON the car!!!!");
        }

        public void OpenDoor()
        {
            Console.WriteLine("Door is OPEN!!!!");
        }

        public void CloseDoor()
        {
            Console.WriteLine("Door is CLOSE!!!!");

        }

        public void TurnOff()
        {
            Console.WriteLine("Turn OFF the car!!!!");
        }
    }
}