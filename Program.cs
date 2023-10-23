namespace GradingSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            string scoreInput = Console.ReadLine();
            Grading.GradeCalculator(scoreInput);
        }
    }
}