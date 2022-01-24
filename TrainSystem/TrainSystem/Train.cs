using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSystem
{
    internal class Train
    {
        #region Properties
        public Engine Engine { get; private set; }
        public int GrossWeight
        {
            get
            {

            }
        }
        public int MaxGrossWeight { get; }
        public List<RailCar> RailCars { get; private set; }
        public int TotalCars { get; }
        #endregion

        #region Methods
        public void Add(RailCar car)
        {
            RailCars.Add(car);
        }

        public Train(Engine givenEngine)
        {
            Engine = givenEngine;
        }
        #endregion
    }
}
