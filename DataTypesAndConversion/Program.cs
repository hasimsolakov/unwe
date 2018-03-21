using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesAndConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 280;
            long myLong = myInt;
            byte myByte = (byte)myInt;
            Console.WriteLine("My Byte " + myByte);
            short myShort = (short)myInt;
        }
    }
}
