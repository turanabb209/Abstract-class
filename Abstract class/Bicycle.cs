using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    class Bicycle:Vehicle
    {
        private string _type;
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Type: {Type}");
        }
        public override void DefineNatureHarmness()
        {
            Console.WriteLine("None");
        }
    }
}
