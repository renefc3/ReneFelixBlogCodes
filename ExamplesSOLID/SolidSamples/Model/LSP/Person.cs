using System;

namespace Model.LSP
{
    public static class Person
    {
        /// <summary>
        /// Calçar Pé esquerdo
        /// </summary>
        /// <param name="shoe"> Can't be any show only the left</param>
        /// <param name="sock"> There is no diference</param>
        public static void PuttingOnLeftFootBreakingLSP(Shoe shoe, Sock sock)
        {
            Console.WriteLine("Putting socks {0} on the left foot!", sock.Side);
            if (shoe.Side != "Left")
            {
                Console.WriteLine("Wrong foot!");
            }
            else
            {
                Console.WriteLine("Putting shoes {0} on the left foot!", shoe.Side);    
            }
        }

        /// <summary>
        /// Calçar Pé Direito
        /// </summary>
        /// <param name="shoe"></param>
        /// <param name="sock"> There is no diference</param>
        public static void PuttingOnRightFootBreakingLSP(Shoe shoe, Sock sock)
        {
            Console.WriteLine("Putting socks {0} on the righ foot!", sock.Side);
            if (shoe.Side != "Right")
            {
                Console.WriteLine("Wrong foot!");
            }
            else
            {
                Console.WriteLine("Putting shoes {0} on the righ foot!", shoe.Side);
            }
        }





        /// <summary>
        /// Calçar Pé esquerdo
        /// </summary>
        /// <param name="shoe"></param>
        /// <param name="sock"></param>
        public static void PuttingOnLeftFootUsingLSP(LeftShoe shoe, Sock sock)
        {
            Console.WriteLine("Putting socks {0} on the left foot!", sock.Side);
            Console.WriteLine("Putting shoes {0} on the left foot!", shoe.Side);     
        }


        /// <summary>
        /// Calçar Pé Direito
        /// </summary>
        /// <param name="shoe"></param>
        /// <param name="sock"></param>
        public static void PuttingOnRightFootUsingLSP(RightShoe shoe, Sock sock)
        {
            Console.WriteLine("Putting socks {0} on the righ foot!", sock.Side);
            Console.WriteLine("Putting shoes {0} on the righ foot!", shoe.Side);
        }


    }
}