

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
            var hints = new Dictionary<CodePeg, ResultPeg>();

            for (int i = 0; i < code.Count; i++)
            {
                var positionGame = i;
                var colorcode = code[i];

                for (int j = 0; j < guess.Count; j++)
                {
                    var position = j;
                    var color = guess[j];

                    if (colorcode.Equals(color) && positionGame == position)
                    {
                        if (hints.ContainsKey(colorcode))
                        {
                            hints.Add(color, ResultPeg.Black);
                        }
                        else
                        {
                            hints.Add(color, ResultPeg.Black);
                        }
                    }
                    else if (color.Equals(colorcode))
                    {
                        if (hints.ContainsKey(color))
                            continue;
                        hints.Add(color, ResultPeg.White);
                    }
                }
            }
            return new List<ResultPeg> (hints.Values);
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
