namespace Ch07FunWithQuizzes;

public class ShortAnswer : Question
{
    public ShortAnswer(string prompt)
        : base(prompt) { }

    public override string ToString()
    {
        string nl = Environment.NewLine;
        return nl + Prompt + nl + "Please enter a response (80 characters max):" + nl;
    }
}
