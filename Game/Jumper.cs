using System;

namespace jumper
{
    public class Jumper
    {
        public void display(int track)
        {
            TerminalService ts = new TerminalService();
            if (track == 0)
            {
                ts.WriteText("  ___  ");
                ts.WriteText(" /___\\ ");
                ts.WriteText(" \\   / ");
                ts.WriteText("  \\ /  ");
                ts.WriteText("   0   ");
                ts.WriteText("  /|\\  ");
                ts.WriteText("  / \\  ");
                ts.WriteText("       ");
                ts.WriteText("^^^^^^^");
                ts.WriteText("       ");
            }
            else if (track == 1)
            {
                ts.WriteText(" /___\\ ");
                ts.WriteText(" \\   / ");
                ts.WriteText("  \\ /  ");
                ts.WriteText("   0   ");
                ts.WriteText("  /|\\  ");
                ts.WriteText("  / \\  ");
                ts.WriteText("       ");
                ts.WriteText("^^^^^^^");
                ts.WriteText("       ");
            }
            else if (track == 2)
            {
                ts.WriteText(" \\   / ");
                ts.WriteText("  \\ /  ");
                ts.WriteText("   0   ");
                ts.WriteText("  /|\\  ");
                ts.WriteText("  / \\  ");
                ts.WriteText("       ");
                ts.WriteText("^^^^^^^");
                ts.WriteText("       ");
            }
            else if (track == 3)
            {
                ts.WriteText("  \\ /  ");
                ts.WriteText("   0   ");
                ts.WriteText("  /|\\  ");
                ts.WriteText("  / \\  ");
                ts.WriteText("       ");
                ts.WriteText("^^^^^^^");
                ts.WriteText("       ");
            }
            else if (track == 4)
            {
                ts.WriteText("   X   ");
                ts.WriteText("  /|\\  ");
                ts.WriteText("  / \\  ");
                ts.WriteText("       ");
                ts.WriteText("^^^^^^^");
                ts.WriteText("       ");
            }
            else
            {
                ts.WriteText("ERROR");
            }
        }
    }
}

    // Just for testing.
    /*public class Program
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
*/
