using System.Collections.Generic;

namespace MasterMind.Resources
{
    public class Mastermind
    {
        private readonly List<CodePeg> code;

        public Mastermind(List<CodePeg> code)
        {
            this.code = code;
        }

        public List<ResultPeg> GetHints(List<CodePeg> guess)
        {
            var hints = new List<ResultPeg>();

            for (int i = 0; i < guess.Count; i++)
            {
                var positionGame = i;
                var color = guess[i];
                for (int j = 0; j < code.Count; j++)
                {
                    var position = j;
                    var colorcode = code[j];

                    if (color.Equals(colorcode) && positionGame == position)
                    {
                        hints.Add(ResultPeg.Black);
                    }
                    else if (color.Equals(colorcode))
                    {
                        hints.Add(ResultPeg.White);
                    }
                }
            }
            return hints;
        }
    }

    public enum CodePeg
    {
        Black,
        Blue,
        Green,
        Red,
        White,
        Yellow,
    }

    public enum ResultPeg
    {
        Black,
        White,
    }
}
