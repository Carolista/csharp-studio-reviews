namespace Ch07FunWithQuizzes;

public class MultipleChoice : Question
{
    public MultipleChoice(string prompt, Choice[] choiceArr)
        : base(prompt, choiceArr) { }

    public override string ToString()
    {
        string nl = Environment.NewLine;
        return nl + "CHOOSE ONE:" + nl + Prompt + nl + GetFormattedChoices();
    }
}
