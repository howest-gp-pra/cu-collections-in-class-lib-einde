using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prb.ClassesAndObjects.Core
{
    public class CarType
    {
        public string TypeName { get; set; }
        public bool IsCommercial { get; set; }
        public CarType(string typeName, bool isCommercial)
        {
            TypeName = typeName;
            IsCommercial = isCommercial;
        }
        public override string ToString()
        {
            string symbol = "NC";  // NC = not commercial
            if (IsCommercial)
                symbol = "C"; // C = commercial;
            return $"{TypeName} - {symbol}";
        }
    }
}
