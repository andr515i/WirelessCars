using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WirelessCars
{
    class Program
    {
        static void Main(string[] args)
        {
            WirelessCar WC = new WirelessCar(); // WC stands for Wireless Car

            Console.Write(" to start the car, please insert key by typing 1. type 0 to cancel\n");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)  // temporary start of car, to make sure we only create one for now
            {
               

                Console.WriteLine(" what color is your car?\n ");
                WC.color = Console.ReadLine();

                Console.WriteLine(" what brand is your car then? \n");
                WC.name = Console.ReadLine(); 
                WC.TurnOn();
            }
            else
            {
                // closes program to signal cancellation was successfull
            }

             
            while (WC.isCarTurnedOn)    // saving this for later, basically a game loop to test various 
            {
                Console.WriteLine(" what action would you like to take?\n 1 to drive forward, 2 to recharge the car's internal battery, 3 to turn car off, 4 to buy a new car \n");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine(" how many times would you like to drive forward? \n");
                        int driveAmount = int.Parse(Console.ReadLine());
                        WC.Drive(driveAmount);
                        break;
                    case 2:
                        Console.WriteLine(" your car has been recharged");
                        WC.Recharge();
                        break;
                    case 3:
                        Console.WriteLine(" you successfully turned your car off");
                        WC.TurnOff();
                        break;
                    case 4:
                        WirelessCar WC2 = new WirelessCar();
                        Console.WriteLine(" what color would you like your new car in?");
                        WC2.color = Console.ReadLine();

                        Console.WriteLine(" what brand would you like to purchase? we currently have a nice 0.05% discount on bugatti cars");
                        WC2.name = Console.ReadLine();

                        WC2.TurnOn();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
