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
        //UC1 TC1.1:-Respond Sad Mood
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
        //UC1 TC1.2:-Respond Happy Mood
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

    }
}