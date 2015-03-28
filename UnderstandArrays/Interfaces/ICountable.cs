using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandArrays.Interfaces
{
    interface ICountable
    {
        void Count();
        int Result { get; set; }
    }
}
