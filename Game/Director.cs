using System;
using System.Collections.Generic;

namespace jumper
{
    public class Director
    {
        TerminalService ts = new TerminalService();
        SecretWord word = new SecretWord();
        Jumper jumper = new Jumper();
        bool is_playing = true;
        
        int tracker = 0;
        public string letter;
        private string secretWord;
        
        List<string> guessWord = new List<string>();
        
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
            bool relapse = true;
            ts.WriteText($"{word.guessWord}");
            jumper.display(tracker);
            while (relapse)
            {
                letter = ts.ReadText("What letter do you want to guess now?(a-z)");
                relapse = word.letterTracker(letter);
                if (relapse)
                {
                    ts.WriteText("You already guessed this letter");
                }
            }
            is_playing = true;
        }

        //supposed to update users score
        public void do_updates()
        {
            if (!is_playing)
            {
                return;
            }

            word.secretWordStatus(letter);
            if (!word.secretWord.Contains(letter))
            {
                tracker += 1;
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

            if (tracker == 4)
            {   
                jumper.display(tracker);
                ts.WriteText("You Lost.");
                ts.WriteText($"The word was {word.secretWord}");
                is_playing = false;
            }

            else if(!word.guessWord.Contains("_"))
            {
                ts.WriteText("You Won!");
                ts.WriteText($"The word was {word.secretWord}");
                is_playing = false;
            }
        }
    }
}
