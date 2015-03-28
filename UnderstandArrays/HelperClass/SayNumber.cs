using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderstandArrays.Interfaces;

namespace UnderstandArrays
{
    class SayNumber : ICountable
    {
        private int[] yourTable;
        private int ile;
        private int _result;

        public SayNumber()
        {
            Console.WriteLine("How many numbers do you want give me?");
            var val = Console.ReadLine(); 
            int.TryParse(val, out ile);
            Console.WriteLine(ile);
            // Or you could wirte
            // ile = Console.Read() !
        }
        public void GiveMeXTimes()
        {
            int j = 0;
            for(int i=0; i<ile; i++)
            {
                Console.WriteLine("Please, give me numer({0})- TODAY! : ", j+1);
                yourTable[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enought! Thanks mate!");
        }
        public void Count()
        {
            foreach (var item in yourTable)
            {
                Result += item;
            }
        }

        public int Result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
            }
        }

        public void Show()
        { 
            foreach (var item in yourTable)
	        {
                Console.WriteLine(item);
            }                
        }
    }
}
