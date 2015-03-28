using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            SayNumber saynumber = new SayNumber();
            saynumber.GiveMeXTimes();
            saynumber.Count();
            saynumber.Show();
        }
    }
}
