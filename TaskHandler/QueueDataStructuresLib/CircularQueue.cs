using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskHandler.QueueDataStructuresLib
{
    public class CircularQueue : IQueueDataStructure
    {
        public CircularQueue()
        {
        }

        public void Clear()
        {
            Console.WriteLine("Circular Clear");
        }

        public void Dequeue()
        {
            Console.WriteLine("Circular Dequeue");

        }

        public void Enqueue()
        {
            Console.WriteLine("Circular Enqueue");

        }
    }
}

