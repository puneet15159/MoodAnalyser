using System;

namespace MoodAnalyser
{
    public class MoodAnalyserUtility
    {
        private string message;

        public MoodAnalyserUtility()
        {
        }

        public MoodAnalyserUtility(string message)
        {
            this.message = message;
        }

        public string analyseMood()
        {
            if (message == null || message == "")
            {
                throw new MoodAnalysisException("This is a invalid Mood", MoodAnalyser.MoodAnalysisException.ExceptionType.INVALID_MOOD);
            }
            try
            {
                if (message.Equals("happy") || message.Equals("I am in any mood"))
                {
                    return "happy";
                }
                else
                    return "sad";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException("This is a null message",MoodAnalysisException.ExceptionType.INVALID_MOOD);
            }
            
            
        }
    }
}