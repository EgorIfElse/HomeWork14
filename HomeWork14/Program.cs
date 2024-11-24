using System.Reflection.Metadata.Ecma335;

namespace HomeWork14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка", "Мяу-мяу");
            Dog dog = new Dog("Борис");
            cat.ShowInfo();
            Console.WriteLine();
            dog.ShowInfo();

        }
    }

    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.Write(Name);
            Say();
        }

    }

    class Cat : Animal
    {
        string voice;
        string name;
        public override string Name
        {
            get =>  name; 
            set => name = value; 
        }

        public Cat(string name, string voice)
            : base(name)
        {
            this.voice = voice;
        }

        public override void Say()
        {
            Console.Write($" - { voice}");
        }
    }
    

    class Dog : Animal
    {
        string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Dog(string name)
        : base(name)
        { }
        public override void Say()
        {
            Console.WriteLine(" - Гав-гав");
        }


    }
}
    

        

           
       



