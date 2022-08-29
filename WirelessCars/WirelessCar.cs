using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WirelessCars
{
    class WirelessCar
    { //properties on the wireless cars
        private string _color;  // color of the car
        private int _batteryCharge = 100;  // battery out of box, always 100 so we just declare it now
        private int _meterCounter;  // the total amount of meters driven on the current battery charge
        private string _name;
        public bool isCarTurnedOn = false; // true if car is turned on, false if car is turned off
        
        public int meterCounter { get => _meterCounter; set => _meterCounter = value; }
        public string color { get => _color; set => _color = value; }
        public int batteryCharge { get => _batteryCharge; set => _batteryCharge = value; }
        public string name { get => _name; set => _name = value; }

        public void TurnOn() // turns car on so car can function
        {
            isCarTurnedOn = true; // turn the car on
            DisplayAllStatistics(); //display all information on car
        }



        public void TurnOff() // turns car off so car cannot function
        {
            // turns the car off
            //display all information on car?
            isCarTurnedOn = false; // turn the car off
            DisplayAllStatistics();
        }
        public void Drive(int driveTimes)  // how many times we drive the car
        {
            if (this.isCarTurnedOn)
            {
                if (this._batteryCharge > 0) //we check outside the for loop to make sure we even have the battery to go
                {
                    // drives 20 meters forward, and drains battery in increments of 1(%)
                    for (int i = 0; i < driveTimes; i++)
                    {
                        if (this._batteryCharge > 0) // check inside for battery left, to make sure that we dont go into negative 
                        {
                            DrainBattery();
                            MeterCounterIncrease();
                        }
                        else
                        {
                            ResetCarStatistics();
                            break;
                        }
                    }
                }
                else
                {
                    ResetCarStatistics();
                }
            }
            DisplayStatistics();
        }
        private void DrainBattery() // drains battery when driving
        {

            this._batteryCharge--; // we remove 1 % battery charge when driving once

        }

        private void MeterCounterIncrease() // increases meter counter when driving
        {
            this._meterCounter += 20; // here we increase the meter counter by 20

        }
        private void ResetCarStatistics() // here we reset the meters and battery to defualt values
        {
            Recharge(); 

            Console.WriteLine(" You have driven so far that your battery has run out, and will be charging for the next fortnight to regain power");
                
        }
        public void DisplayStatistics() // displays normal stats on car
        {
            Console.WriteLine(" --- current battery charge: " + this._batteryCharge + "%\ndistance until recharge is needed: " + (this.batteryCharge * 20) + " --- \n\n");
        }
        private void DisplayAllStatistics() // displays all stats on car
        {
            Console.WriteLine(" --- current battery charge: " + this._batteryCharge + "%\n" + "current meter count: " + this._meterCounter + "\nthe color of this car is: " + this._color + "\ncar's brand: " + this.name +" \ndistance until recharge is needed: " + (this.batteryCharge * 20) + " --- \n\n");
        
        }
        public void Recharge()
        {
            this.meterCounter = 0;
            this.batteryCharge = 100;

        }


    }

}
