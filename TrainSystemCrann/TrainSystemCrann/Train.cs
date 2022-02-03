using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSystemCrann
{
    internal class Train
    {
        public Engine Engine { get; set; }

        public int GrossWeight { get; }

        public int MaxGrossWeight { get; }

       /* public RailCar {get; set; }*/ /*going to be a list*/

        public int TotalCars { get; }

       
        public List<RailCar> RailCars { get; set; }
        public Train(Engine givenEngine, int GrossWeight, int MaxGrossWeight, List<RailCar> railcars, int TotalCars)
        {
            this.Engine = givenEngine;
            this.GrossWeight = GrossWeight;
            this.MaxGrossWeight = MaxGrossWeight;
            this.TotalCars = TotalCars;
        }

    }
}
