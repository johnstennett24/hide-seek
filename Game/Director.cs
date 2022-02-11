using System;
using System.Collections.Generic;

namespace jumper
{
    public class Director
    {
        bool is_playing = true;
        int score = 0;
        
        public Director()
        {
        }

        //starts the game and keeps it going
        public void start_game()
        {
            while (is_playing)
            {
                get_inputs();
                do_updates();
                do_outputs();               
            }
        }

        //asks the user if what word they want to guess
        public void get_inputs()
        {
            SecretWord word = new SecretWord();
            Console.WriteLine("What letter do you want to guess now(a-z)? ");
            string jumper_word = Console.ReadLine();
            is_playing = true;
        }

        //supposed to update users score
        public void do_updates()
        {
            if (!is_playing)
            {
                return;
            }
        }

        //should display the word and the score.
        //also asks player if they want to try the word again
        //it showed more red lines if I didn't have a ";" after the ()
        public void do_outputs()
        {
            if (!is_playing)
            {
                return;
            }

            Jumper jumper = new Jumper();
        }
    }
}
