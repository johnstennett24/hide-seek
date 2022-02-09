using System;
using System.Collections.Generic;

namespace Jumpergame
{
    public class Director
    {
        List<jumper> jumper = new List<jumper>();
        bool is_playing = true;
        int score = 0;
        int total_score = 0;
    
        
        public Director()
        {
           //I wasn't sure what to put here so I left it blank

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
        public void get_inputs(){
            Console.WriteLine("What letter do you want to guess now? ");
            string jumper_word=Console.ReadLine();
            is_playing=(//unsure what to type here)
        }
        //supposed to update users score
        public void do_updates;
        {
            if (!is_playing)
            {
                return;
            }
            
            score = 0;
            foreach (Jumper word in words)
            {//just copied it from director dice game, didn't know what needed to be here
                die.Roll();
                score += die.points;
            }
            total_score += score;
        }
        //should display the word and the score.
        //also asks player if they want to try the word again
        //it showed more red lines if I didn't have a ";" after the ()
        public void do_outputs();
        {
            if (!is_playing)
            {
                return;
            }
        

            string values = "";
            foreach (Jumper word in words)
            {
             values += ($"{word.value}");
            }

            Console.WriteLine($"you got: {values}");
            Console.WriteLine($"Your Score is: {total_score}\n");
            is_playing =(StringComparer > 0);
        }   
    }
}
