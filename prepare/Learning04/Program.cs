class Program
{
    static void Main(string[] args)
    {
        var student = new Assignment("Samuel Bennett", "Multiplication");
        var math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        var la = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.Clear();
        Console.WriteLine(student.GetSummary());
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine(la.GetSummary());
        Console.WriteLine(la.GetWritingInformation());
    }
}