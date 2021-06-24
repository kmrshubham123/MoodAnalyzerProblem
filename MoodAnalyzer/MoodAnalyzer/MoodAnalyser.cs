using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        public string message;
        /// <summary>
        /// Parameterised Constructor.
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        /// <summary>
        ///UC1:-Analyse Happy And Sad Mood
        ///if messege Contain Sad then return Sad
        ///if message contain Happy then return Happy
        /// </summary>
        /// <returns></returns>
        public string AnalyseMood()
        {
            if (this.message.Contains("Sad")) //Contains():- This method is used to check whether the substring occurs within a given string or not.
                return "Sad";
            if (this.message.Contains("Happy"))
                return "Happy";

            return null;
        }
       
    }
}
