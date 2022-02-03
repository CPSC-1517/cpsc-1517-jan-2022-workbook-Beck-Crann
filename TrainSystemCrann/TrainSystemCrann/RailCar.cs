using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSystemCrann
{
    internal class RailCar
    {
        private int _Capacity;
        private int _LightWeight;
        private int _LoadLimit;
        private string _SerialNumber;
        private int _GrossWeight; //have to check if i can code this here


        /*need to code type of railcar from RailCarType -- enum: Maybe just need to code it as below?
         in service -- bool value*/

        public int Capacity /*Load Limit and Capacity are in terms of the freight itself. This is the net weight of the railcar*/
        // must be less than load limit
        {
            get { return _Capacity; }
            private set
            {
                if (Utilities.IsPositive(value))
                    throw new ArgumentNullException("Capacity must be greater than 0.");
                if (value > _LoadLimit)
                    throw new ArgumentOutOfRangeException("Capacity must be less than Load Limit");

                _Capacity = value;
            }
        }
        public int GrossWeight /*must be between light weight and gross load limit (LoadLimit + LightWeight*/
        {
            get { return _GrossWeight; }
            private set
            {
                _GrossWeight = LoadLimit + LightWeight;

                _GrossWeight = value;
            }
        }
        public bool InService { get; set; } /*I think public, note CAN be altered by property ie here (this is the property)*/

        public bool IsFull { get; }  /*within 90% of full load means IsFull*/

        public int LightWeight
        {
            get { return _Capacity; }
            private set
            {
                if (Utilities.IsPositive(value))
                    throw new ArgumentNullException("Light Weight value must be greater than 0.");
                _LightWeight = value;
            }
        }

        public int LoadLimit /*Load Limit and Capacity are in terms of the freight itself. This is the net weight of the railcar,*/
        {
            get { return _LoadLimit; }
            private set
            {
                if (Utilities.IsPositive(value))
                    throw new ArgumentNullException("Load Limit value must be greater than 0.");
                _LoadLimit = value;
            }
        }

      /*  public int NetWeight    *//*freight weight only*//*
        {
         
        }*/

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

        public RailCarType Type { get; set; }



        public RailCar(string serialnumber, int lightweight, int capacity, int loadlimit, RailCarType type, bool inservice)
        {
            SerialNumber = serialnumber.Trim();
            LightWeight = lightweight; // trim doesn't work on ints, use something to remove whitespace
            Capacity = capacity; // trim doesn't work on ints, use something to remove whitespace
            LoadLimit = loadlimit; // trim doesn't work on ints, use something to remove whitespace
            Type = type;
            InService = inservice; /*going to try this out*/
        }

        public void RecordScaleWeight(int grossweight)
        {

        }

        public override string ToString()
        {
            return $"{SerialNumber}, {LightWeight}, {Capacity}, {LoadLimit}, {Type}, {InService}";
        }
    }
}
