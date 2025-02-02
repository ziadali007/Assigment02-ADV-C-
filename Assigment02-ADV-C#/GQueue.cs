using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment02_ADV_C_
{
    internal class GQueue
    {
        private Queue<object> queue = new Queue<object>();
        public void Enqueue(object item)
        {
            queue.Enqueue(item);
        }

        public object Dequeue()
        {
            return queue.Dequeue();
        }

        
    }
}
