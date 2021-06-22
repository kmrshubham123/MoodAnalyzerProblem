using System;

namespace MoodAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Mood Analyser Problem****");
            //UC1:-Respond Happy and Sad Mood
            MoodAnalyser analyser = new MoodAnalyser("I am in Sad Mood");
            MoodAnalyser analysermood = new MoodAnalyser("I am in Any Mood");
            Console.WriteLine("I am in Sad Mood:- "+ analyser.AnalyseMood());
            Console.WriteLine("I am in Any Mood:- "+ analysermood.AnalyseMood());
        }
    }
}
