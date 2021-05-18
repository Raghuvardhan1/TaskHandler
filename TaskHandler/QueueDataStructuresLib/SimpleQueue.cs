using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskHandler.QueueDataStructuresLib
{
    public class SimpleQueue : IQueueDataStructure
    {
        public SimpleQueue()
        {
        }

        public void Clear()
        {
            Console.WriteLine("Simple Clear");
        }

        public void Dequeue()
        {
            Console.WriteLine("Simple Dequeue");
         
        }

        public void Enqueue()
        {
            Console.WriteLine("Simple Enqueue");
            
        }
    }
}
