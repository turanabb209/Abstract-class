using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{//Vehicle abstract classı:
// - FactoryName
 //- Model
 //- Color
 //- DriveTime
 //- DrivePath
 // - AverageSpeed() -  Ortalama sürəti hesablayır(km/saat mentiqi ile yani path ve time dan istifade edirsiz)
 //- GetInfo() virtual method yaradirsiz miras oturduyu classda override etdikde butun deyerleri ekrana cixarmalidir.
 //- ToString() methodunu override edirsiz ekrana cixartdiqda FactoryName ile Model deyerlerini gostersin
 //- DefineNatureHarmness() - abstract method-dur override etdikde benzinle ishleyenlerde high,
 //electrikle ishleyenlerde low, motorsuz ishleyen araclarda none cixarsin.
   abstract class Vehicle
    {
        private string _factoryName;
        private string _model;
        private string _color;
        private double _driveTime;
        private double _drivePath;

        public string FactoryName
        {
            get
            {
                return _factoryName;
            }
            set
            {
                _factoryName = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model=value;

            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public double DriveTime
        {
            get
            {
                return _driveTime;
            }
            set
            {
                _driveTime = value;
            }
        }
        public double DrivePath
        {
            get
            {
                return _drivePath;
            }
            set
            {
                _drivePath = value;
            }
        }

        public void AverageSpeed()
        {    if (DrivePath > 0 && DriveTime > 0)
            {
                Console.WriteLine("AverageSpeed=" + DrivePath / DriveTime);
            }
            else
            {
                Console.WriteLine(" AverageSpeed hesablamaq ucun zehmet olmasa deyisenleri duzgun daxil edin ");
            }
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"FactoryName: {FactoryName}\n Model:{Model}\n Color:{Color}\n DriveTime:{DriveTime}\n DrivePath:{DrivePath} ");
        }
        public override string  ToString()
        {
            return $"FactoryName:{FactoryName}\n Model:{Model}";
        }
        public abstract void DefineNatureHarmness();

    }
}
