namespace Ch07FunWithQuizzes;

public class Paragraph : Question
{
    public Paragraph(string prompt)
        : base(prompt) { }

    public override string ToString()
    {
        string nl = Environment.NewLine;
        return nl + Prompt + nl + "Please enter a response (500 characters max):" + nl;
    }
}
