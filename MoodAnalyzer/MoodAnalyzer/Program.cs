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
            Console.WriteLine("I am in Sad Mood:- " + analyser.AnalyseMood());
            MoodAnalyser analysermood = new MoodAnalyser("I am in Happy Mood");
            Console.WriteLine("I am in Happy Mood:- "+ analysermood.AnalyseMood());
            //UC2:-
            MoodAnalyser moodAnalyser = new MoodAnalyser("");
            Console.WriteLine("Given Null Message:- "+ moodAnalyser.AnalyseMood());
        }
    }
}
