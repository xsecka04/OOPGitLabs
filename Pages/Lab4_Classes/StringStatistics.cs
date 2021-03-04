using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace OOPGitLabs.Pages.Lab4_Classes
{
    public class StringStatistics
    {

        public StringStatistics(string s)
        {
            Text = s;
        }

        private string[] splitWords;
        private string[] splitSentences;
        private string[] splitLines;
        private int getMax;
        private int getMin;

        private string _Text;
        public string Text
        {
            get
            {
                return _Text;
            }
            set
            {
                _Text = value;
                splitWords = Regex.Split(value, @"(?<=[\s\.\!\?])(?=[\p{Ll}\p{Lu}({[])")
                    .Select(w => w.Trim(' ','(',')','.','!','?','\n',',')).ToArray();

                splitSentences = Regex.Split(value, @"(?<=[\.\!\?])\s+(?=[\p{Lu}])");
                splitLines = Regex.Split(value, @"(?<=[\n])");
                getMax = splitWords.Max(w => w.Length);
                getMin = splitWords.Min(w => w.Length);

            }
        }

        public int GetWordCount()
        {
            return splitWords.GetLength(0);
        }

        public int GetSentCount()
        {
            return splitSentences.GetLength(0);
        }

        public int GetLineCount()
        {
            return splitLines.GetLength(0);
        }


        public string GetMostCommon()
        {
            string tmp = splitWords.GroupBy(w => w).OrderByDescending(w => w.Count()).First().First();
            return tmp;
        }

        public string GetLongestWord()
        {
            string[] tmp = splitWords.Where(w => w.Length == getMax).ToArray();
            return string.Join(", ", tmp);
        }

        public string GetShortestWord()
        {
            string[] tmp = splitWords.Where(w => w.Length == getMin).ToArray();
            return string.Join(", ", tmp);

        }

        public string GetAlphabeticalOrder()
        {
            string[] tmp = splitWords.OrderBy(w => w).ToArray();
            return string.Join(", ", tmp);

        }


    }
}

