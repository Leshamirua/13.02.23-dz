using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._23_dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device device = new Kettle("name","desc");
            device.Sound();

        }
    }
}
