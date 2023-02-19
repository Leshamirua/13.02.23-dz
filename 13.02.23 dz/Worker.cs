using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._23_dz
{
    abstract internal class Worker
    {
        abstract public void Print();
    }
    class President:Worker
    {
        public override void Print()
        {
            Console.WriteLine("It's a President");
        }
    }
    class Security: Worker
    {
        public override void Print() { Console.WriteLine("It's a Security"); }
    }
    class Manager : Worker
    {
        public override void Print() { Console.WriteLine("It's a Manager"); }
    }
    class Engineer: Worker
    {
        public override void Print() { Console.WriteLine("It's an Engineer"); }
    }
}
