using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskHandler.QueueDataStructuresLib;
namespace TaskHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueueDataStructure queue = new SimpleQueue();
            TaskSchedular taskSchedular = new TaskSchedular(queue);
            TaskManager taskManager = new TaskManager(queue);
            taskSchedular.AddTask();
            taskManager.DeleteTask();
            queue = new CircularQueue();
            taskSchedular.QueueDataStructure = queue;
            taskManager.QueueDataStructure = queue;
            taskSchedular.AddTask();
            taskManager.DeleteTask();
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();

        }
    }
}
