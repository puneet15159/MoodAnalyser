using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    [Serializable]
    public class MoodAnalysisException : Exception 
    {
        public ExceptionType type;
        private ExceptionType iNVALID_MOOD;

        public enum ExceptionType
        {
            INVALID_MOOD
        }
        public MoodAnalysisException(string message, Exception type)
        : base(message) { }

        public MoodAnalysisException(string message, ExceptionType iNVALID_MOOD) : base(message)
        {
            this.iNVALID_MOOD = iNVALID_MOOD;
        }
    }
}
