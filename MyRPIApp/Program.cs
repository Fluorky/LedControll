// See https://aka.ms/new-console-template for more information

using System;
using System.Device.Gpio;
using System.Threading;



namespace MyRPIApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int LED_PIN = 17;
            using var controller = new GpioController();
            controller.OpenPin(LED_PIN, PinMode.Output);
            bool lastState = true;
           
            for(int i=0; i<10; i++)
            {
                controller.Write(LED_PIN, lastState);
                Console.WriteLine("LED is {0}", lastState ? "on" :"off");
                lastState =!lastState;
                Thread.Sleep(2000);

            }
            
        }
    }
}

