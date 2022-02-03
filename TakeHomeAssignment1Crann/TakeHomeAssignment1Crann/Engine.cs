using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomeAssignment1Crann
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
            private set {/* _HP = value; */}
        }
        public string Model
        {
            get { return _Model; }
            private set { }
        }
        public string SerialNumber
        {
            get { return _SerialNumber; }
            private set { }
        }
        public int Weight
        {
            get { return _Weight; }
            private set { }
        }
    }
}
