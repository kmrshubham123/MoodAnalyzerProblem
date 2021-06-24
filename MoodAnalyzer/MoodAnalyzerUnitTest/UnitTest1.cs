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
            string expected = "Happy";
            //Act
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            //Assert
            Assert.AreEqual(expected, moodAnalyser.AnalyseMood());
        }

    }
}