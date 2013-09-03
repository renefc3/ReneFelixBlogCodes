using System;

namespace Model.ISP
{
    public class MotorcycleBreakingISP : IVehicleBreakingISP
    {
        public void TurnOn()
        {
            Console.WriteLine("Turn ON the Motorcycle!!!!");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turn OFF the Motorcycle!!!!");

        }

        /// <summary>
        /// Do Not Call this
        /// </summary>
        public void OpenDoor()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Do Not Call this
        /// </summary>
        public void CloseDoor()
        {
            throw new NotImplementedException();
        }
    }
}