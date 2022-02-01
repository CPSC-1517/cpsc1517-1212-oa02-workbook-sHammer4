using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSystem
{
    internal class Engine
    {
        #region Private Fields
        private int _HP;
        private string _Model;
        private string _SerialNumber;
        private int _Weight;
        #endregion

        #region Readonly Properties
        public int HP 
        { 
            get { return _HP; }
            private set
            {
                if (value < 3500 || value > 5500)
                {
                    throw new ArgumentException("Engine HP must be between 3500 and 5500"); 
                }
                if(value % 100 != 0)
                {
                    throw new ArgumentException("Engine HP must be measure in 100 HP increments");
                }
            }
        }
        public string Model
        {
            get { return _Model; }
            private set // Allows internal access within current class only. Externet access is not allowed
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Engine Model value is required");
                }
                _Model = value.Trim();
            }
        }
        public string SerialNumber
        {
            get { return _SerialNumber; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Engine SerialNumber value is required");
                }
                _SerialNumber = value.Trim();
            }
        }
        public int Weight
        {
            get { return _Weight; }
            private set
            {
                if(value >= 0)
                {
                    throw new ArgumentException("Weight must be a positive and non-zero whole number.");
                }
                if(value % 100 != 0)
                {
                    throw new ArgumentException("Weight must be in 100 pound increments.");
                }
                _Weight = value;
            }
        }
        #endregion

        #region Methods
        public Engine(string model, string serialNumber, int weight, int hp)
        {
            _Model = model;
            _SerialNumber = serialNumber;
            _Weight = weight;
            _HP = hp;
        }

        public override string ToString()
        {
            return String.Format($"{_HP},{_Model},{_SerialNumber},{_Weight}");
        }
        #endregion
    }
}
