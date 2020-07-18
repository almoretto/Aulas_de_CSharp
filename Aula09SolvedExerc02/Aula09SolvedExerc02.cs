using System;

namespace Aula09SolvedExerc02
{
    class Aula09SolvedExerc02
    {
        static void Main(string[] args)
        {
            Coment c1 = new Coment("Have a nice trip");
            Coment c2 = new Coment("Wow that's awesome!");
            Posts p1 = new Posts(
                DateTime.Parse("21/06/2018 13:05:44"), 
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!", 
                12);
            p1.AddComent(c1);
            p1.AddComent(c2);

            Coment c3 = new Coment("Have a nice trip");
            Coment c4 = new Coment("Wow that's awesome!");
            Posts p2 = new Posts(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);
            p2.AddComent(c3);
            p2.AddComent(c4);

            Console.WriteLine(p1);
            Console.WriteLine();
            Console.WriteLine(p2);

            Console.ReadLine();
        }
    }
}
