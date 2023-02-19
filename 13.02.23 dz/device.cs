using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._23_dz
{
    abstract internal class Device
    {
        public string name;
        public string description;
        public Device (string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        public Device() { }
        public abstract void Sound();
        public virtual void Show()
        {
            Console.WriteLine($"Name: {name}");
        }
        public virtual void Desc()
        {
            Console.WriteLine($"Character :{description}");
        }
    }
    class Kettle:Device
    {
        public Kettle() { }
        public Kettle(string name, string description) : base(name, description) { }
        public override void Sound() { Console.WriteLine("Prprprprprprprprprpr");}
    }
    class Microwave:Device
    {
        public Microwave() { }
        public Microwave(string name, string description) : base(name, description) { }
        public override void Sound() { Console.WriteLine("Bip bzzhhhzhhhhhhzhzhzhzhhhhhh dzin"); }
    }
    class Auto : Device
    {
        public Auto() { }
        public Auto(string name, string description) : base(name, description) { }
        public override void Sound() { Console.WriteLine("Vrummm vrum vrum"); }
    }
    class Ship : Device
    {
        public Ship() { }
        public Ship(string name, string description) : base(name, description) { }
        public override void Sound() { Console.WriteLine("Tuuuuuu tuuuuuuuuuuuuuu"); }
    }
}
