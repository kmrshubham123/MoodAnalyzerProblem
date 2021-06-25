using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyserCustomException : Exception // Exception:Represent error that occur during application Execution
    {
        /// <summary>
        /// Enum for Exception Type
        /// </summary>
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE, NO_SUCH_FIELD, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }
        //creating 'type' variable of the type ExceptionType
        public readonly ExceptionType type;
        /// <summary>
        /// Parameterized constructor sets the Exception Type and message
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="message"></param>
        public MoodAnalyserCustomException(ExceptionType Type, string message): base(message)
        {
            this.type = Type;
        }
    }
}
