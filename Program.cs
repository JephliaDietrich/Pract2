namespace Pract2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree("No tree yet", 0, 0, "Has nothing", 0);
            Console.WriteLine($"About the three.");
            Console.WriteLine();
            tree.Info();
            Console.WriteLine();
            tree.Informinput();
            Console.WriteLine();
            tree.Info();
            Console.WriteLine();
            tree.Сhecks("");
            tree.Output();

            Flower flower = new Flower("", 0, 0, "", "");
            Flower flower1 = new Flower("Magic", 0.5, 1, "black", "Lilia");
            Console.WriteLine($"About the flower");
            Console.WriteLine();
            Console.WriteLine(flower1.ToString());
            Console.WriteLine();
            flower.Informinput();
            Console.WriteLine();
            flower.Info();
            Console.WriteLine();
            flower.FlowerOut();

            Console.WriteLine();
            Console.WriteLine();
            flower.ToString();
            Console.WriteLine();

            if (flower.Equals(flower1))
            {
                Console.WriteLine("These are identical flowers!");
            }
            else
            {
                Console.WriteLine("These are different flowers.");
            }


        }
    }
}
