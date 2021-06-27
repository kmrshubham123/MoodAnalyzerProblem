using System;
using System.Collections.Generic;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {

        public string message;
        /// <summary>
        /// Unparametrized Constructor
        /// </summary>
        public MoodAnalyser()
        {

        }
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
            try // Block of Code to be tested ,for error while it is being executed
            {
                
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE,"Mood should not be Empty");
                }
                if (this.message.Contains("Sad")) //Contains():- This method is used to check whether the substring occurs within a given string or not.
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException)// Block of code to be Executed if an error in the block
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
            catch (MoodAnalyserCustomException exception)
            {
                return exception.Message;
            }

        }
    }
}    
