using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Omalley_Lauren
{
    class Horror : Game
    {
        // Sets the Esrb string equal to esrbParam and the Title string equal to titleParam
        public Horror(string esrbParam, string titleParam) : base(esrbParam, titleParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
        }

        // Prints the title and the esrb in the sentence (the title value) is a horror game rated (the esrb value)!
        public override string Describe()
        {
            return $"{Title} is a Horror game rated {Esrb}!";
        }

    }
}
