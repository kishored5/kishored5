using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace types
{
    public struct SNumber
    {
        public int value { get; set; }

        public SNumber (int value)
        {
            this.value = value;
        }
        public override string ToString()
        {
            return $"SNumber({value.ToString()})";
        }

    }
}
