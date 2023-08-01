using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceEvent
{


    internal class EventExample
    {
        public delegate void PublisherEventhandler(object source, EventArgs e);
        public event PublisherEventhandler TaskFinish;

        public void ActionMaker(string situation)
        {
            Console.WriteLine("Task process started.");
            Thread.Sleep(5000);

            OnTaskFinish();
        }

        protected virtual void OnTaskFinish()
        {
            if(TaskFinish != null) TaskFinish(this, EventArgs.Empty);
        }
    }
}
