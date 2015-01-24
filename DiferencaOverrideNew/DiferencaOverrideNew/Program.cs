using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiferencaOverrideNew
{
    class Program
    {
        static void Main(string[] args)
        {

            MyBaseObject myBaseObject = new MyFirstConcreteObject();
            MyFirstConcreteObject myConcreteObject = new MyFirstConcreteObject();

            Console.WriteLine("myBaseObject");
            myBaseObject.MethodForNew();
            myBaseObject.MethodForOverride();
            myBaseObject.MethodForOverride2();

            Console.WriteLine("");
            Console.WriteLine("myConcreteObject");
            myConcreteObject.MethodForNew();
            myConcreteObject.MethodForOverride();
            myConcreteObject.MethodForOverride2();


            Console.ReadKey();



        }
    }


    public abstract class MyBaseObject
    {
        public  abstract void MethodForOverride2();

        public virtual void MethodForOverride()
        {
            Console.WriteLine("MethodForOverride of MyBaseObject");
        }

        public void MethodForNew()
        {
            Console.WriteLine("MethodForNew of MyBaseObject");
        }


    }

    public class MyFirstConcreteObject : MyBaseObject
    {
        public override void MethodForOverride2()
        {
            Console.WriteLine("MethodForOverride2 of MyFirstConcreteObject");
        }

        public override void MethodForOverride()
        {
            Console.WriteLine("MethodForOverride of MyFirstConcreteObject");
        }
        public new void MethodForNew()
        {
            Console.WriteLine("MethodForNew of MyFirstConcreteObject");
        }
    }


}
