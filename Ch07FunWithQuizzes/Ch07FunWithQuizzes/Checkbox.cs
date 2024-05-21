namespace Ch07FunWithQuizzes;

public class Checkbox : Question
{
    public Checkbox(string prompt, Choice[] choiceArr)
        : base(prompt, choiceArr) { }

    public override string ToString()
    {
        string nl = Environment.NewLine;
        return nl + "CHOOSE ONE OR MORE:" + nl +
            Prompt + nl +
            GetFormattedChoices();
    }
}
