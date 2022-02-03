using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*have to add incremented by 100 validation to HP*/
namespace TrainSystem
{
    internal class Engine
    {
        private int _HP;
        private string _Model;
        private string _SerialNumber;
        private int _Weight;

        public int HP  /*person class from example*/
        {
            get { return _HP; }
            private set 
            {
                if (!Utilities.IsPositive(value))
                {
                    throw new ArgumentException("HP must be positive value");
                }
                else if (value < 3500 || value > 5500)
                {
                    throw new ArgumentException("HP must be between 3500 and 5500");
                }
                _HP = value;
            }
           
        }
        public string Model
        {
            get { return _Model; }
            private set 
            {
                if(Utilities.IsEmpty(value))
                    throw new ArgumentNullException("Model is required.");
                _Model = value;
            }
        }
        public string SerialNumber
        {
            get { return _SerialNumber; }
            private set 
            {
                if(Utilities.IsEmpty(value))
                    throw new ArgumentNullException("Serial Number is required.");
                _SerialNumber = value;
            }
        }
        public int Weight
        {
            get { return _Weight; }
            private set 
            {
                if(Utilities.IsEmpty(value))
                   throw new ArgumentNullException("Weight is required.");
               _Weight = value;
            }
        }

        public Engine(string model, string serialnumber, int weight, int hp)
        {
            Model = model.Trim();
            SerialNumber = serialnumber.Trim();
            Weight = weight.Trim();
            HP = hp.Trim();
        }

       public override string ToString()
        {
            return $"{Model},{SerialNumber},{Weight},{HP}";
        }
    }
}
