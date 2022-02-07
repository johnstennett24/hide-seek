using System;

namespace jumper
{
    public class chute
    {
        public void display(int track)
        {
            if (track == 0)
            {
                Console.WriteLine("  ___  ");
                Console.WriteLine(" /___\\ ");
                Console.WriteLine(" \\   / ");
                Console.WriteLine("  \\ /  ");
                Console.WriteLine("   0   ");
                Console.WriteLine("  /|\\  ");
                Console.WriteLine("  / \\  ");
                Console.WriteLine("       ");
                Console.WriteLine("^^^^^^^");
                Console.WriteLine("       ");
            }
            else if (track == 1)
            {
                Console.WriteLine(" /___\\ ");
                Console.WriteLine(" \\   / ");
                Console.WriteLine("  \\ /  ");
                Console.WriteLine("   0   ");
                Console.WriteLine("  /|\\  ");
                Console.WriteLine("  / \\  ");
                Console.WriteLine("       ");
                Console.WriteLine("^^^^^^^");
                Console.WriteLine("       ");
            }
            else if (track == 2)
            {
                Console.WriteLine(" \\   / ");
                Console.WriteLine("  \\ /  ");
                Console.WriteLine("   0   ");
                Console.WriteLine("  /|\\  ");
                Console.WriteLine("  / \\  ");
                Console.WriteLine("       ");
                Console.WriteLine("^^^^^^^");
                Console.WriteLine("       ");
            }
            else if (track == 3)
            {
                Console.WriteLine("  \\ /  ");
                Console.WriteLine("   0   ");
                Console.WriteLine("  /|\\  ");
                Console.WriteLine("  / \\ ");
                Console.WriteLine("       ");
                Console.WriteLine("^^^^^^^");
                Console.WriteLine("       ");
            }
            else if (track == 4)
            {
                Console.WriteLine("   X   ");
                Console.WriteLine("  /|\\  ");
                Console.WriteLine("  / \\  ");
                Console.WriteLine("       ");
                Console.WriteLine("^^^^^^^");
                Console.WriteLine("       ");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int wrong;
            Console.WriteLine("How many times have you guessed wrong?");
            wrong = Convert.ToInt32(Console.ReadLine());
            chute pw = new chute();
            pw.display(wrong);
        }
    }
}