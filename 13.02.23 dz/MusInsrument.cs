using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._23_dz
{
    abstract internal class MusInstument
    {
        public string name;
        public string description;
        public MusInstument(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        public MusInstument() { }
        public abstract void Sound();
        public abstract void History();
        public virtual void Show()
        {
            Console.WriteLine($"Name: {name}");
        }
        public virtual void Desc()
        {
            Console.WriteLine($"Character :{description}");
        }
    }
    class Violin : MusInstument
    {
        public Violin() { }
        public Violin(string name, string description) : base(name, description) { }
        public override void Sound() { Console.WriteLine("Uiiii uiiiii"); }
        public override void History() { Console.WriteLine("Violin history"); }
    }
    class Trombone : MusInstument
    {
        public Trombone() { }
        public Trombone(string name, string description) : base(name, description) { }
        public override void Sound() { Console.WriteLine("Uoom Uooooom"); }
        public override void History() { Console.WriteLine("Trombone history"); }
    }
    class Ukulele : MusInstument
    {
        public Ukulele() { }
        public Ukulele(string name, string description) : base(name, description) { }
        public override void Sound() { Console.WriteLine("Brim birim"); }
        public override void History() { Console.WriteLine("Ukulele history"); }
    }
    class Сello : MusInstument
    {
        public Сello() { }
        public Сello(string name, string description) : base(name, description) { }
        public override void Sound() { Console.WriteLine("Uyyyy uyyyy"); }
        public override void History() { Console.WriteLine("Сello history"); }
    }
}
