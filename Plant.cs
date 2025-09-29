using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2
{
    public class Plant
    {
        protected string name;
        protected double hight;
        protected double age;


        public Plant(string name, double hight, double age)
        {
            this.name = name;
            this.hight = hight;
            this.age = age;
        }
        public string Name
        {
            get { return name; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine($"The name cannot be empty.");
                    name = "nothing";
                } else
                    name = value;
                    }
        }
        public double Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {

                    Console.WriteLine($"Age cannot be negative.");
                    age = 0;

                }
                else
                    age = value;
            }
        }
        public double Hight
        {
            get { return hight; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine($"Hight cannot be negative.");
                    hight = 0;
                }
                else
                    hight = value;
            }
        }
        public virtual void Informinput()
        {
            Console.WriteLine($"Enter updated information for the plant.");
            Console.WriteLine();
            Console.Write($"Name: ");
            string? namePlant = Console.ReadLine();
            this.Name = namePlant;

            Console.WriteLine();
            Console.Write($"Age: ");
            string? agePlant = Console.ReadLine();
            double age1 = double.Parse(agePlant);
            this.Age = age1;

            Console.WriteLine();
            Console.Write($"Hight: ");
            string? hightPlant = Console.ReadLine();
            double hight1 = double.Parse(hightPlant);
            this.Hight = hight1;
        }
        public virtual void Info()
        {
            Console.WriteLine($"This is {Name}, {Age} years old and is {Hight} cm tall.");
        }
    }

     public class Tree : Plant
    {
        public string fruit;
        public int rings;

        public Tree(string name, double hight, double age, string fruit, int rings) : base(name, age, hight)
        {
            this.fruit = fruit;
            this.rings = rings;
        }

        public string Fruit
        {
            get { return fruit; }
            set { if (value == "yes") 
                {
                    Console.WriteLine();
                    Console.WriteLine($"Your tree bears fruit.");
                    fruit = "Your tree has fruit";
                }
                else if(value == "no")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Your tree is not bearing fruit.");
                    fruit = "Your tree has no fruit";
                }
            }
        }

        public int Rings
        {
            get { return rings; }
            set { if(value <= 30)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Your tree is young.");
                    rings = value;
                } else if(30 < value||value <= 80)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Your tree is middle-aged.");
                    rings = value;
                } else if(value > 80)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Your tree is elderly.");
                    rings = value;
                }
            }
        }

        public override void Info()
        {
            Console.WriteLine($"This is {Name}, {Age} years old and is {Hight} cm tall.{Fruit} and has {Rings} rings.");
        }

        public override void Informinput()
        {
            base.Informinput();

            Console.WriteLine($"Enter additional information for your tree.");
            Console.WriteLine();
            Console.Write($"Does your tree bear fruit? Write yes or no with a lowercase letter: ");
            string? fruitTree = Console.ReadLine();
            this.Fruit = fruitTree;

            Console.WriteLine();
            Console.Write($"How many rings does your tree have? Rings: ");
            string? ringsTree = Console.ReadLine();
            int rings1 = int.Parse(ringsTree);
            this.Rings = rings1;
        }

        public void Сhecks(string Name)
        {
            Console.WriteLine($"Enter the name of the tree and the number of rings of the tree you are looking for into the database.");
            Console.WriteLine();
            Console.Write($"Name: ");
            string? name1Tree = Console.ReadLine();
            Console.WriteLine();
            Console.Write($"Rings: ");
            string? rings1Tree = Console.ReadLine();
            int rings2 = int.Parse(rings1Tree);
            if (name1Tree == Name || rings2 == Rings)
            {
                Console.WriteLine();
                Console.WriteLine($"We have this tree with this number of rings in its trunk. Here is detailed information about this tree.");
                Info();
            } else
            {
                Console.WriteLine();
                Console.WriteLine($"We do not have a tree with that name and with that number of rings in its trunk." + name1Tree + $" " + rings2);
            }
        }

        public void Output()
        {
            Console.WriteLine();
            Console.WriteLine($"3 main characteristics of the tree. Name - {Name}, rings - {Rings} and age - {Age}.");
        }
    }

    public class Flower : Plant
    {
        public string color;
        public string type;

        public Flower(string name, double hight, double age, string color, string type) : base(name, age, hight)
        {
            this.color = color;
            this.type = type;
        }

        public string Color
        {
            get { return color; }
            set {

                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine($"The color cannot be empty.");
                    color = "nothing";
                }
                else
                    color = value;

            }
        }

        public string Type
        {
            get { return type; }
            set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine($"The type cannot be empty.");
                    type = "nothing";
                }
                else
                    type = value;

            }
        }

        public override void Informinput()
        {
            base.Informinput();

            Console.WriteLine($"Enter additional information for your flower.");

            Console.WriteLine();

            Console.Write($"What colour is your flower? Color: ");
            string? colorFlower = Console.ReadLine();
            this.Color = colorFlower;
        }

        public void FlowerOut()
        {
            Console.WriteLine($"What type is your flower? Type:");
            string? typeFlower = Console.ReadLine();
            this.Type = typeFlower;

            Console.WriteLine($"This is a {Name} {Type}. This flower is {Color} in colour.");
        }
    }
}
