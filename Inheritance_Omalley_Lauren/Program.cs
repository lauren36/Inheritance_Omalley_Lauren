using System;

namespace Inheritance_Omalley_Lauren
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sets a value for the title and esrb as Outlast and M
            Horror myHorror = new Horror("M", "Outlast");

            // Prints the (title) is starting to the console for the Outlast game
            Console.WriteLine(myHorror.Describe());
            myHorror.PlayGame();

            // Sets a value for the title and esrb as CS:GO and M
            FPS csGo = new FPS("M", "CS:GO");

            // Prints the (title) is starting to the console for the CS:GO game
            Console.WriteLine(csGo.Describe());
            csGo.PlayGame();
        }
    }
}
