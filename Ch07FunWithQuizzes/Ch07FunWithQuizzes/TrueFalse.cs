namespace Ch07FunWithQuizzes;

public class TrueFalse : Question
{
    public TrueFalse(string prompt, Choice[] choiceArr)
        : base(prompt, choiceArr) { }

    public override string ToString()
    {
        string nl = Environment.NewLine;
        return nl + "TRUE OR FALSE:" + nl + Prompt + nl + GetFormattedChoices();
    }
}
