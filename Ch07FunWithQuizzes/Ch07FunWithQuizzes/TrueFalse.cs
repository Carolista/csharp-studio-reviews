namespace Ch07FunWithQuizzes;

public class TrueFalse : Question
{
    public TrueFalse(string prompt, bool isTrue)
        : base(prompt, [new Choice("True", isTrue), new Choice("False", !isTrue)]) { }

    public override string ToString()
    {
        string nl = Environment.NewLine;
        return nl + "TRUE OR FALSE:" + nl + Prompt + nl + GetFormattedChoices();
    }
}
