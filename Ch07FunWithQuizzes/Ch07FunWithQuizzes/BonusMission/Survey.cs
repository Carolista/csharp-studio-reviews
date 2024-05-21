namespace Ch07FunWithQuizzes;

public class Survey : Quiz
{
    public readonly List<string> allResponses = [];

    public override void Run()
    {
        foreach (Question question in questions)
        {
            Console.WriteLine(question);
            string userResponse = Console.ReadLine();
            allResponses.Add(userResponse);
        }
    }
}
