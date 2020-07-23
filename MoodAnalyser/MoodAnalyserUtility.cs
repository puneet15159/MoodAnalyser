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
            if (message == null)
            {
                return "happy";
            }
            try
            {
                if (message.Equals("happy") || message.Equals("I am in Any Mood"))
                {
                    return "happy";
                }
                else
                    return "sad";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException("please enter proper message");
            }
            
            
        }
    }
}