using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProject
{
    public class StackDemo
    {
        static void Main(string[] args)
        {
            Stack<int> s= new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);

            while (s.Count > 0)
            {
                int e=s.Pop();
                Console.WriteLine("poped elements are:"+e);
            }
        }
    }
}
