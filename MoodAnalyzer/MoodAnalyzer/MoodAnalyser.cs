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
        /// if messege contain Invalid mood(Null) or Empty throw an exception,return Happy
        ///if messege Contain Sad then return Sad
        ///if message contain Happy then return Happy
        /// </summary>
        /// <returns></returns>
        public string AnalyseMood()
        {
            try // Block of Code to be tested for error while it is being executed
            { 
                if (this.message.Contains("Sad"))//Contains():- This method is used to check whether the substring occurs within a given string or not.
                    return "Sad";
                if (this.message.Contains("Happy"))
                    return "Happy";
                if (this.message.Contains(null))
                    return "Happy";
            }
            catch // Block of code to be Executed if an error in the block
            {
                return "Happy";
            }
            return null; // Value Return for all code path (AnalyseMood)
        }
    }
}
