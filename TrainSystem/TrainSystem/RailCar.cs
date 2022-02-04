using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSystem
{
    internal class RailCar
    {
        #region Private fields
        private int _Capacity;
        private int _LightWeight;
        private int _LoadLimit;
        private string _SerialNumber;
        private RailCarType _Type;
        #endregion

        #region Properties
        public int Capacity
        {
            get { return _Capacity; }
            private set
            {
                if (value >= _LoadLimit)
                {
                    throw new ArgumentException("RailCar Capacity must be a lower value than the LoadLimit");
                }
                if (value % 100 != 0)
                {
                    throw new ArgumentException("RailCar Capacity must be measured in 100lbs increments");
                }
                _Capacity = value;
            }
        }
        public int GrossWeight { get; private set; }
        public bool InService { get; private set; }
        public bool IsFull
        {
            get
            {
                if (NetWeight < 0.9 * Capacity)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public int LightWeight
        {
            get { return _LightWeight; }
            private set
            {
                if (value % 100 != 0)
                {
                    throw new ArgumentException("RailCar LightWeight must be measured in 100lbs increments");
                }
                _LightWeight = value;
            }
        }
        public int LoadLimit
        {
            get { return _LoadLimit; }
            private set
            {
                if (value % 100 != 0)
                {
                    throw new ArgumentException("RailCar LoadLimit must be measured in 100lbs increments");
                }
                _LoadLimit = value;
            }
        }
        public int NetWeight
        {
            get { return GrossWeight - LightWeight; }
        }
        public string SerialNumber
        {
            get { return _SerialNumber; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("RailCar SerialNumber value is required");
                }
                _SerialNumber = value.Trim();
            }
        }
        public RailCarType Type
        {
            get { return _Type; }
            private set { _Type = value; }
        }
        #endregion

        #region Methods
        public RailCar(string serialNumber, int lightWeight, int capacity, int loadLimit, RailCarType type, bool inService)
        {
            SerialNumber = serialNumber;
            LightWeight = lightWeight;
            LoadLimit = loadLimit;
            Capacity = capacity;
            Type = type;
            InService = inService;
        }

        public void RecordScaleWeight(int grossWeight)
        {
            if (grossWeight < _LightWeight)
            {
                throw new ArgumentException("Scale Error - RailCar GrossWeight must be a greater value than the LightWeight");
            }
            else if (grossWeight > _LightWeight + LoadLimit)
            {
                throw new ArgumentException("Unsafe Load - RailCar GrossWeight must be less than the gross Load Limit (LightWeight + LoadLimit)");
            }
            else if (grossWeight % 100 != 0)
            {
                throw new ArgumentException("RailCar GrossWeight must be measured in 100lbs increments");
            }
            else
            {
                GrossWeight = grossWeight;
            }
        }

        public override string ToString()
        {
            return $"{Capacity},{GrossWeight},{InService},{IsFull},{LightWeight},{LoadLimit},{NetWeight},{SerialNumber},{Type}";
        }
        #endregion
    }
}
