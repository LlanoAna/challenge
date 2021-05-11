using System;
using System.Collections.Generic;
using MasterMind.Resources;

namespace MasterMind
{
   public class Program
    {
        static void Main(string[] args)
        {
            var mastermind = new Mastermind(new List<CodePeg> { CodePeg.Black, CodePeg.Blue, CodePeg.Green, CodePeg.Yellow });
            var hints = mastermind.GetHints(new List<CodePeg> { CodePeg.Green, CodePeg.Black, CodePeg.White, CodePeg.White });

            foreach (var hint in hints)
            {
                Console.WriteLine(hint);
            }

        }
    }
}
