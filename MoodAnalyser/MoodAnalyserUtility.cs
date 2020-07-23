using System;

namespace MoodAnalyser
{
    public class MoodAnalyserUtility
    {
        public MoodAnalyserUtility()
        {
        }

        public string analyseMood(String message)
        {
            try
            {
                if (message.Equals("happy"))
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