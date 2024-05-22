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

        string line = "-------------------------------------------------------------------";

        Console.WriteLine(line);
        Console.WriteLine(
            "Thank you for taking our survey! We have recorded your responses."
                + Environment.NewLine
        );

        foreach (KeyValuePair<string, string> kvp in allResponses)
        {
            Console.WriteLine(kvp.Key);
            Console.WriteLine(kvp.Value);
        }
        Console.WriteLine(line);
    }
}
