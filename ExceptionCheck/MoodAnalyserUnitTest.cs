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
                string mood = moodAnalyser.analyseMood("happy");
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
                MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility();
                string mood = moodAnalyser.analyseMood("I am in Sad Mood");
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
                MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility();
                string mood = moodAnalyser.analyseMood("I am in Any Mood");
                Assert.AreEqual("happy", mood);
            }
            catch (MoodAnalyser.MoodAnalysisException e)
            {
                Assert.AreEqual("please enter proper message", e.Message);
            }
        }
        /*[Test]
        public void givenNullMood_WhenAnalyse_ShouldReturnNullException()
        {
            try
            {
                MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility();
                string mood = moodAnalyser.analyseMood(null);
                *//*Assert.AreEqual("happy", mood);*//*
            }
            catch (MoodAnalyser.MoodAnalysisException e)
            {
                Assert.AreEqual("please enter proper message", e.Message);
            }
        }*/
    }
}