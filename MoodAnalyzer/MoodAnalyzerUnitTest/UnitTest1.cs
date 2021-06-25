using NUnit.Framework;
using MoodAnalyzer;

namespace MoodAnalyzerUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        //TC1.1:-Respond Happy and Sad Mood
        [Test]
        public void Method_Return_Sad()
        {
            //Arrange
            string expected = "Sad";
            //Act
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Sad Mood");
            //Assert
            Assert.AreEqual(expected, moodAnalyser.AnalyseMood());
        }
        //TC1.2
        [Test]
        public void Method_Return_Happy()
        {
            //Arrange
            string expected = "Happy";
            //Act
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Happy Mood");
            //Assert
            Assert.AreEqual(expected, moodAnalyser.AnalyseMood());
        }
        //TC2.1:-Null mood Should Return Happy
        [Test]
        public void NullMood_Return_Happy()
        {
            //Arrange
            string expected ="Mood should not be Empty";
            //Act
            MoodAnalyser moodAnalyser = new MoodAnalyser("");
            string actual = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //TC3.1:-Given empty mood should Thow Mood AnalysisException Indicating Empty mood
        [Test]
        public void Given_Empty_Mood_Should_Thow_Mood_AnalysisException_Indicating_Empty_Mood()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyseMood();
            }
            catch(MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood Should not be Empty", e.Message);
            }
        }
        [Test]
        //TC3.2:-Empty mood Should throw Empty Mood
        public void GivenEmptyUsingCustomException()
        {
            //Arrange
            string expected = "Mood should not be Empty";
            //Act
            MoodAnalyser moodAnalyser = new MoodAnalyser("");
            string actual = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}