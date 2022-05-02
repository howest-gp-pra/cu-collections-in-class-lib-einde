using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prb.ClassesAndObjects.Core
{
    public class Car 
    {
        private int topSpeed;

        public string Brand { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public CarType CarType { get; set; }
        public int TopSpeed
        {
            get { return topSpeed; }
            set
            {
                if (value < 0)
                    topSpeed = 0;
                else
                    topSpeed = value;
            }
        }

        public Car()  
        {
        }
        public override string ToString()
        {
            return $"{Brand} - {CarType}";
        }
    }

}
