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
                int sumOfWeight = 0;
                foreach (RailCar currentRailCar in RailCars)
                {
                    sumOfWeight += currentRailCar.GrossWeight;
                }
                return sumOfWeight + Engine.Weight;
            }
        }
        public int MaxGrossWeight
        {
            get
            {
                return Engine.HP * 2000;
            }
        }
        public List<RailCar> RailCars { get; private set; }
        public int TotalCars
        {
            get
            {
                return RailCars.Count();
            }
        }
        #endregion

        #region Methods
        public void Add(RailCar car)
        {
            if (car.GrossWeight + GrossWeight >= MaxGrossWeight)
            {
                throw new ArgumentException("RailCar GrossWeights excees the MaxGrossWeight of the Train.");
            }
            else
            {
                RailCars.Add(car);
            }
        }

        public Train(Engine givenEngine)
        {
            Engine = givenEngine;
        }
        #endregion
    }
}
