using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Omalley_Lauren
{
    abstract class Game
    {
        // Creates a public string called Esrb
        public string Esrb { get; set; }
        // Creates a public string called Title
        public string Title { get; set; }

        // Sets the Esrb string equal to esrbParam and the Title string equal to titleParam
        public Game(string esrbParam, string titleParam)
        { 
            Esrb = esrbParam;
            Title = titleParam;
        }



        /// <summary>
        /// Prints the title and says it is starting.
        /// </summary>
            public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting!");
        }

        public abstract string Describe();

    }
}
