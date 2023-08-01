using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceEvent
{
    internal class Subscriber
    {
        public void SubscriberMethod(object source, EventArgs e)
        {
            Console.WriteLine("the task finish is reported. I am going to broadcase that.");
            Thread.Sleep(4000);
            Console.WriteLine("Now the whole worlk knows that you finished your task.");
        }
    }
}
