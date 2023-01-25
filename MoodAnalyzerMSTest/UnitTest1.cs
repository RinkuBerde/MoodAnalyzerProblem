using MoodAnalyzerProblem;

namespace MoodAnalyzerMSTest
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {           
            //Arrange
            string expected = "I am in a Sad Mood";
            MoodAnalyzer mood = new MoodAnalyzer(expected);

            //Act
            string actual = mood.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenAnyMoodShouldReturnHAPPY()
        {
            //Arrange
            string expected = "I am in Any Mood";
            MoodAnalyzer mood = new MoodAnalyzer(expected);

            //Act
            string actual = mood.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void TestAnalyseMood_ShouldReturnHAPPY1()
        {
            //Arrange
            string message = null;
            MoodAnalyzer mood = new MoodAnalyzer(message);

            //Act
            string result = mood.AnalyzeMood();

            //Assert
            Assert.AreEqual(result, "HAPPY?!!");
        }
    }
}
