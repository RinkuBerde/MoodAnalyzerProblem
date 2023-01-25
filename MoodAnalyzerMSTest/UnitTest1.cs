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
        //Test Case 3.1
        [TestMethod]
        public void GivenNullMoodShouldThrowMoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
                string actual = moodAnalyzer.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Mood should not be null", ex.Message);
            }
        }
        //Test Case 3.2
        [TestMethod]
        public void GivenEmptyMoodShouldThrowMoodAnalysisException()
        {
            try
            {
                string message = "";
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
                string actual = moodAnalyzer.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Mood should not be empty", ex.Message);
            }
        }
        [TestMethod]
        public void GivenMoodAnalyzeClasssNameShouldReturnMoodAnalyzeObject()
        {
            string message = null;
            object expected = new MoodAnalyzer(message);
            object obj = MoodAnalyzerFactory.CreateMoodAnalyze("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
        }
    }
}
