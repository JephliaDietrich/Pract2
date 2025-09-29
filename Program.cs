namespace Pract2
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
            Console.WriteLine($"About the flower");
            Console.WriteLine();
            flower.Informinput();
            Console.WriteLine();
            flower.Info();
            Console.WriteLine();
            flower.FlowerOut();

        }
    }
}
