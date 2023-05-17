namespace LoopsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //While loop
            Console.WriteLine("WHILE LOOP:");
            var cont = "yes";
            while (cont == "yes")
            {
                Console.WriteLine("Continue? (Type 'yes' or 'no')");
                cont = Console.ReadLine();
            }

            Console.WriteLine("Outside of the loop.");
            Console.WriteLine("Press enter.");
            Console.ReadKey();


            //Do While loop
            Console.WriteLine("DO-WHILE LOOP:");
            var num = 1;

            do
            {
                Console.WriteLine(num);
                num++;
            } while (num <= 5);

            Console.WriteLine("Outside of the loop");
            Console.WriteLine("Press enter.");
            Console.ReadKey();


            //For loop
            Console.WriteLine("FOR LOOP:");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} is the lap we are on");
            }
            Console.WriteLine("Outside of the loop");
            Console.WriteLine("Press enter.");
            Console.ReadKey();

            //Foreach loop
            Console.WriteLine("FOREACH LOOP:");
            var numbers = new int[] { 5, 8, 10, 44, 500, 6 };

            foreach(var number in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Outside of the loop");
        }
    }
}