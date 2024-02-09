using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProject
{
    public class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue<int> q= new Queue<int>();

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);

            while(q.Count > 0)
            {
                int e= q.Dequeue();
                Console.WriteLine("Dequeue elements are: "+e);
            }
        }
    }
}
