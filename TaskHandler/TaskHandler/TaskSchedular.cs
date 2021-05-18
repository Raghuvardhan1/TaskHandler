using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskHandler.QueueDataStructuresLib;
namespace TaskHandler
{
    class TaskSchedular
    {
        private IQueueDataStructure _queueDataStructure;
        public TaskSchedular(IQueueDataStructure queueDataStructure)
        {
            QueueDataStructure = queueDataStructure;
        }

        public void AddTask()
        {
            QueueDataStructure.Enqueue();
        }

        public IQueueDataStructure QueueDataStructure { get => _queueDataStructure; set => _queueDataStructure = value; }
    }
}
