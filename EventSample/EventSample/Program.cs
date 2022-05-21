using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample
{
    //grepper Events in C# (EventHandler, event, RaiseEvent, Invoke Event)
    class Program
    {
        static void Main(string[] args)
        {
            EventDemo ed = new EventDemo();
            ed.MyEvent += Ed_MyEvent;

            ed.RaiseEvent();

            Console.ReadKey();
        }

        private static void Ed_MyEvent(object sender, string e)
        {
            Console.WriteLine($"Event ausgelöst {e}");
        }
    }


    public class EventDemo
    {
        private EventHandler<string> MyEventHandler;
        public event EventHandler<string> MyEvent;


        public void RaiseEvent()
        {
            if (MyEvent != null)
            {
                MyEvent.Invoke(this, "Data");
            }
        }

    }
    //end grepper
}
