using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSystemCrann
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
                //modulus operator is % example odd/even
                //if the number is divisible by 2 it is even , with a remainder of 0
                // if the number is NOT divisible by 2 it is odd and the remainder is 1
                // variable % 2 I can test the result: if (variable % 2 == 0) even else odd

                // weights must be in multiples of 100 so a number is said to be in a multiple of 100 the remainder is 0
                // if (variable % 100 == 0) is multiple else is NOT multiple

                // 38800 % 100 result is 0 (388 * 100)
                // 38880 % 100 result is 80 (388.8 * 100)
            }

        }
        public string Model
        {
            get { return _Model; }
            private set
            {
                if (Utilities.IsEmpty(value))
                    throw new ArgumentNullException("Model is required.");
                _Model = value;
            }
        }
        public string SerialNumber
        {
            get { return _SerialNumber; }
            private set
            {
                if (Utilities.IsEmpty(value))
                    throw new ArgumentNullException("Serial Number is required.");
                _SerialNumber = value;
            }
        }
        public int Weight
        {
            get { return _Weight; }
            private set
            {
                if (!Utilities.IsPositive(value))               
                    throw new ArgumentException("Weight is required.");             
                _Weight = value;
            }
        }

        public Engine(string model, string serialnumber, int weight, int hp)
        {
            Model = model.Trim();
            SerialNumber = serialnumber.Trim();
            Weight = weight; // can't use trim on an int
            HP = hp;
        }

        public override string ToString()
        {
            return $"{Model},{SerialNumber},{Weight},{HP}";
        }
    }
}
