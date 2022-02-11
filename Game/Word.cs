using System;
using System.Collections.Generic;

namespace jumper
{
    /// <summary>
    /// <para>The person who tries to guess the word</para>
    /// <para>
    /// The responsability of the player is to keep the track of the letters that the player guessing.
    /// </para>
    /// </summary>

    public class SecretWord
    {
        private List<string> wordList = new List<string>()
        {
            "peanuts","carrots","cork","air","sidewalk","cat","puddle","packet","eraser","toilet","flowers","book","bottle","tree","coasters","watch","soda","headphones","drill",
            "tissue","picture","clippers","keyboard","clock","leg","car","candle","desk","stick","card","chain","door","keys","water","cookie","sand","shoes","shampoo","house",
            "twister","note","nail","bag","photo","glasses","television","mop","floor","wallet","block","tv","blanket","box","plastic","chalk","controller","bottle","apple","rubber",
            "magnet","lamp","bracelet","pants","knife","mouse","outlet","shoe","paper","shawl","spring","balloon","paper","paint","lotion","ring","tooth","sofa","glass","stockings",
            "needle","drawer","purse","seat","white","bananas","hanger","shade","soap","chocolate","food","window","thread","pen","canvas","eye","hair","button"
        };
        private List<string> guessList = new List<string>();
        
        private bool checker = true;

        var random = new Random();
        int index = random.Next(wordList.Count());
        private string secretWord = wordList[index];

        private List<string> guessWord = new List<string>();
        
        public SecretWord()
        {   
            for (int i = 0; i < secretWord.Length; i++)
            {
                guessWord.Add("_");
            }
        }   

        public bool letterTracker(string letter)
        {
            if (guessList.Any(letter))
            {
                checker = False;
                return checker;
            }
            else
            {
                guessList.add(letter);
                checker = True;
            }
        }

        public string secretWordStatus(string letter, string secretWord, List guessWord)
        {
            List<int> index = new List<int>();
            for (int i = 0; i < secretWord.Length; i++)
            {   
                if (letter == secretWord[i])
                {
                    guessWord[i] = letter;
                }

            }           
        }

    }

}
