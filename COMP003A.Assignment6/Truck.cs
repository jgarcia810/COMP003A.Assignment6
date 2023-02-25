using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    internal class Truck : Vehicle
    {
        /*****fields section******/
        private double _sizeofTruckBed;

        /********constructors section************/
        /// <summary>
        /// Constructor that takes 4 parameters: truckBrand, truckModel,
        /// truckNumberofWheels, and sizeOfTruckBed
        /// It resuses the base class (Vehicle)'s constructor that takes 3 parameters: brand, model, numberOfWheels
        /// </summary>
        /// <param name="truckBrand"></param>
        /// <param name="truckModel"></param>
        /// <param name="truckNumerOfWheels"></param>
        /// <param name="sizeOfTruckBed"></param>
        public Truck(string truckBrand, string truckModel, int truckNumberOfWheels,
            double sizeOfTruckBed) : base(truckBrand, truckModel, truckNumberOfWheels)
        {
            SizeOfTruckBed = sizeOfTruckBed;
        }

        /*********properties section************/
        public double SizeOfTruckBed
        {
            get { return _sizeofTruckBed; }
            set { _sizeofTruckBed = value;}
        }

        /*****methods section*******/
        /// <summary>
        /// Overrides the base Vehicle's definition for GetInfo ()
        /// Calls the base Vehicle GetInfo() but adds on to it
        /// </summary>
        public override void GetInfo()
        {
            Console.WriteLine($"I'm a {nameof(Truck)}");
            base.GetInfo();
            Console.WriteLine($"I also have a {SizeOfTruckBed} ft truck bed");
        }




    }
}
