using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Arduino
{
    class Program
    {
        static void Main(string[] args)
        {



            while (true)
            {
                Serial ser = new Serial();
                ser.GetSerial();
            }



            //}



        }
    }
}
