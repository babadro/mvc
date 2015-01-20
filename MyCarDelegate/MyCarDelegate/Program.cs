using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Delegates as event enablers *****\n");

            Car c1 = new Car("SlugBug", 100, 10);
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));

        }

        #region Delegate tatgets
        public static void OnCarEngineEvent( string msg )
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("***************************************\n");
        }

        public static void onCarEngineEvent2( string msg )
        {
            Console.WriteLine("=> {0}", msg.ToUpper());
        }
        #endregion
    }
}
