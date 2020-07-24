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
                MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility("happy");
                string mood = moodAnalyser.analyseMood();
                Assert.AreEqual("happy", mood);
            }
            catch (MoodAnalyser.MoodAnalysisException e)
            {
                Assert.AreEqual("please enter proper message", e.Message);
            }
        }

        [Test]
        public void givenSadMessage_WhenAnalyse_ShouldReturnTrue()
        {
            try
            {
                MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility("I am in Sad Mood");
                string mood = moodAnalyser.analyseMood();
                Assert.AreEqual("sad", mood);
            }
            catch (MoodAnalyser.MoodAnalysisException e)
            {
                Assert.AreEqual("please enter proper message", e.Message);
            }
        }

        [Test]
        public void givenAnyMoodMessage_WhenAnalyse_ShouldReturnTrue()
        {
            try
            {
                MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility("I am in any mood");
                string mood = moodAnalyser.analyseMood();
                Assert.AreEqual("happy", mood);
            }
            catch (MoodAnalyser.MoodAnalysisException e)
            {
                Assert.AreEqual(MoodAnalysisException.ExceptionType.INVALID_MOOD, e.type);
            }
        }
        [Test]
        public void givenInvalidMood_WhenAnalyse_ShouldReturnTrue()
        {
            try
            {
                MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility(null);
                string mood = moodAnalyser.analyseMood();
                Assert.AreEqual("happy", mood);
            }
            catch (MoodAnalyser.MoodAnalysisException e)
            {
                Assert.AreEqual(MoodAnalysisException.ExceptionType.INVALID_MOOD, e.type);
                
            }
        }
    }
}