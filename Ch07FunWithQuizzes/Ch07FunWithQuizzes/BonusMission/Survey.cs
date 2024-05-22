namespace Ch07FunWithQuizzes;

public class Survey : Quiz
{
    public readonly Dictionary<string, string> allResponses = [];

    public override void Run()
    {
        foreach (Question question in questions)
        {
            Console.WriteLine(question);
            string userResponse = Console.ReadLine();
            allResponses.Add(question.Prompt, userResponse);
        }
    }

    public override void End()
    {
        string nl = Environment.NewLine;
        string line = "-------------------------------------------------------------------";
        Console.WriteLine(line);
        Console.WriteLine("Thank you for taking our survey! We have recorded your responses." + nl);
        foreach (KeyValuePair<string, string> kvp in allResponses)
        {
            Console.WriteLine(kvp.Key);
            Console.WriteLine(kvp.Value + nl);
        }
        Console.WriteLine(line);
    }
}
