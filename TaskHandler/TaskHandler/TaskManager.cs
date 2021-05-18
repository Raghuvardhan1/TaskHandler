using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskHandler.QueueDataStructuresLib;
namespace TaskHandler
{
    class TaskManager
    {
        private IQueueDataStructure _queueDataStructure;
        public TaskManager(IQueueDataStructure queueDataStructure)
        {
            QueueDataStructure = queueDataStructure;
        }

        public void DeleteTask()
        {
            QueueDataStructure.Dequeue();
        }

        public IQueueDataStructure QueueDataStructure { get => _queueDataStructure; set => _queueDataStructure = value; }
    }
}
