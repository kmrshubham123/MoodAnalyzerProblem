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
        [Test]
        public void GivenMood_Return_Sad()
        {
            //Arrange
            string expected = "Sad";
            //Act
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Sad Mood");
            //Assert
            Assert.AreEqual(expected, moodAnalyser.AnalyseMood());
        }

        [Test]
        public void Method_Return_Happy() 
        {
            //Arrange
            string expected = "Happy";
            //Act
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Any Mood");
            //Assert
            Assert.AreEqual(expected, moodAnalyser.AnalyseMood());
        }

    }
}