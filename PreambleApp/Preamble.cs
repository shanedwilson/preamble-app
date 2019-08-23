using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PreambleApp
{
    public class Preamble
    {
        public List<string> makeWords(string preambleText)
        {
            string result = Regex.Replace(preambleText, @"\p{P}", "");

            List<string> preambleSplit = result.Split(" ").ToList();

            return preambleSplit;

        }

        public int makeTWords(string preambleText)
        {
            var preambleSplit = makeWords(preambleText);
            var tWords = new List<string>();

            foreach (string word in preambleSplit)
            {
                if(word.StartsWith('t'))
                {
                    tWords.Add(word);
                };
            }
            return tWords.Count();
        }

        public int makeEWords(string preambleText)
        {
            var preambleSplit = makeWords(preambleText);
            var eWords = new List<string>();

            foreach (string word in preambleSplit)
            {
                if (word.EndsWith('e'))
                {
                    eWords.Add(word);
                };
            }
            return eWords.Count();
        }

        public int makeTEWords(string preambleText)
        {
            var preambleSplit = makeWords(preambleText);
            var tEWords = new List<string>();

            foreach (string word in preambleSplit)
            {
                if (word.StartsWith('t') && word.EndsWith('e'))
                {
                    tEWords.Add(word);
                };
            }
            return tEWords.Count();
        }
    }
}
