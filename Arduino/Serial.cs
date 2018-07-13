using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace Arduino
{
    public class Serial
    {
        public int GetSerial()
        {


            SerialPort myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = "COM3";

            while (true)
            {
                myport.Open();

                int data_rx = myport.ReadChar() - '0';
                //Console.WriteLine(data_rx);
                Console.WriteLine(data_rx);
                //myport.Close();
                Thread.Sleep(200);
                //myport.Close();

                myport.Close();

                return data_rx;
            }





        }
    }
}
