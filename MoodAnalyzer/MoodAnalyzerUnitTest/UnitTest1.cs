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
        [Test]
        //TC4.1:-Given MoodAnalyser Class Name Should Return Mood Anlayser Object
        public void GivenMoodAnalyserClassName_WhenAnalyse_ShouldReturnObject()
        {
            //Arrange
            string message = null;
            //Act
            object expected = new MoodAnalyser(message);
            object resultobj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzer.MoodAnalyser", "MoodAnalyser");
            //Assert
            expected.Equals(resultobj);
        }
        [Test]
        //TC4.2:-Given class Name when improper should throw MoodAnalyserCustomException
        public void Given_Improper_Class_Name_Should_Throw_MoodAnalyserCustomException_Indicating_No_Such_Class()
        {
            try
            {
                //Arrange
                string className = "WrongNamespace.MoodAnalyser";
                string constructorName = "MoodAnalyser";
                //Act
                object resultObj = MoodAnalyserFactory.CreateMoodAnalyse(className, constructorName);
            }
            catch (MoodAnalyserCustomException e)
            {
                //Assert
                Assert.AreEqual("Class Not Found", e.Message);
            }
        }
        [Test]
        //TC4.3:-Given class when constructor improper should throw MoodAnalysisException
        public void Given_Improper_Constructor_Name_Should_Throw_MoodAnalyserCustomException_Indicating_No_Such_Constuctor()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyzer.MoodAnalyser";
                string constructorName = "WrongConstructorName";
                //Act
                object resultObj = MoodAnalyserFactory.CreateMoodAnalyse(className, constructorName);
            }
            catch (MoodAnalyserCustomException e)
            {
                //Assert
                Assert.AreEqual("Constructor is not Found", e.Message);
            }
        }
    }
}