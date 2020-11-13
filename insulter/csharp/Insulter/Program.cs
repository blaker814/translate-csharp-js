using System;
using System.Collections.Generic;

namespace Insulter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] insults = new string[] {
    "You look like what morning breath smells like.",
    "If you tried to give me cpr I would probably throw myself back under water",
    "I am not a fan of you",
    "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
    "I'd rather walk than be on the same plane as you",
    "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
    "Do you have to be so...like that?"
            };

            List<int> indexes = new List<int>();
            while (indexes.Count < 3)
            {
                int candidate = getRandomInt(0, insults.Length);
                if (!indexes.Contains(candidate))
                {
                    indexes.Add(candidate);
                }
            }

            for (int i = 0; i < indexes.Count; i++)
            {
                int index = indexes[i];
                Console.WriteLine(insults[index]);
            }
        }

        // Remember getting a random integer in C# is different
        static int getRandomInt(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max + 1);
        }
    }
}