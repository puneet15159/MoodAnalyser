using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    [Serializable]
    public class MoodAnalysisException : Exception 
    {
        public MoodAnalysisException(string message)
        : base(message) { }
    }
}
