using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    class Car:Vehicle
    {
        private int _doorCount;
        private bool _isElctricCar;
        public int DoorCount
        {
            get
            {
                return _doorCount;
            }
            set
            {
                _doorCount = value;
            }
        }
        public bool IsElctricCar
        {
            get
            {
                return _isElctricCar;
            }
            set
            {
                _isElctricCar = value;
            }
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"DoorCount:{DoorCount}\n IsElctricCar:{IsElctricCar}");

        }
        public override void DefineNatureHarmness()
       
        { bool IsElctricCar = true;
           
            if (IsElctricCar == false)
            {
                Console.WriteLine("High");
            }
            else
            {
                Console.WriteLine("Low");
            }
            return;
        }

    }
}
