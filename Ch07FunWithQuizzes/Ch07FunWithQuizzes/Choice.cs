namespace Ch07FunWithQuizzes;

public class Choice
{

    public string Content { get; set; }
    public bool Correct { get; set; }

    public Choice(string content, bool correct)
    {
        Content = content;
        Correct = correct;
    }

    public Choice(string content) : this(content, false) {}
}
