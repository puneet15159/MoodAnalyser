using MoodAnalyser;
using NUnit.Framework;
using System;

namespace MoodAnalyserTest
{
    public class Tests
    {
        [Test]
        public void givenHappyMood_WhenAnalyse_ShouldReturnTrue()
        {
            try
            {
                MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility();
                string mood = moodAnalyser.analyseMood("Happy");
                Assert.AreEqual("happy", mood);
            }
            catch (MoodAnalyser.MoodAnalysisException e)
            {
                Assert.AreEqual("please enter proper message", e.Message);
            }
        }
        [Test]
        public void givenNullMood_WhenAnalyse_ShouldReturnNullException()
        {
            try
            {
                MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility();
                string mood = moodAnalyser.analyseMood(null);
                /*Assert.AreEqual("happy", mood);*/
            }
            catch (MoodAnalyser.MoodAnalysisException e)
            {
                Assert.AreEqual("please enter proper message", e.Message);
            }
        }
    }
}