using System;

namespace jumper
{
    /// <summary>
    /// <para>The person who tries to guess the word</para>
    /// <para>
    /// The responsability of the player is to keep the track of the letters that the player guessing.
    /// </para>
    /// </summary>

    public class Player
    {
        private List<string> wordList = new List();
        private bool checker = True;

        public Player()
        {

        }

        public void letterTracker(string letter)
        {
            if (wordList.Contains(letter))
            {
                checker = False;
                return checker;
            }
            else
            {
                wordList.add(letter);
                checker = True;
            }
        }

    }

















}