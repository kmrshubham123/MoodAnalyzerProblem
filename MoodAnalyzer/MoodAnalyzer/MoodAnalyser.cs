using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            if (this.message.Contains("Sad")) //Contains():- This method is used to check whether the substring occurs within a given string or not.
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }

        }
    }
}
