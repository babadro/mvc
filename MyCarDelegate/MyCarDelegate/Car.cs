using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarDelegate
{
   public class Car
    {
       public int CurrentSpeed { get; set; }
       public int MaxSpeed { get; set; }
       public string PetName {get; set;}

       private bool carIsDead;

       public Car() { MaxSpeed = 100; }
       public Car( string name, int maxSp, int currSp )
       {
           CurrentSpeed = currSp;
           MaxSpeed = maxSp;
           PetName = name;
       }

        #region Delegate infrastructure

       public delegate void CarEngineHandler( string msgForCaller );
       private CarEngineHandler listOfHandlers;
       public void RegisterWithCarEngine( CarEngineHandler methodToCall)
       {
           if (listOfHandlers == null)
               listOfHandlers = methodToCall;
           else
               Delegate.Combine(listOfHandlers, methodToCall);
       }

       public void UnRegisterWithCarEngine( CarEngineHandler methodToCall )
       {
           listOfHandlers -= methodToCall;
       }
       
       public void Accelerate( int delta )
       {
           if (carIsDead)
           {
               if (listOfHandlers != null)
                   listOfHandlers("Sorry, this car is dead...");
           }
           else
           {
               CurrentSpeed += delta;

               if (10 == (MaxSpeed - CurrentSpeed)
                   && listOfHandlers != null)
               {
                   listOfHandlers("Careful buddy! Gonna blow! ");
               }

               if (CurrentSpeed >= MaxSpeed)
                   carIsDead = true;
               else
                   Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
           }
       }
        #endregion

    }
}
