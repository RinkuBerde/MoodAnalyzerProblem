namespace MoodAnalyzerProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Problem!!!");
            string message = "I am very sad";
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(message);
            System.Console.WriteLine("I am in a {0} mood. ", moodAnalyser.AnalyzeMood());
            Console.ReadKey();
        }
    }
}