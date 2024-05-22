namespace Ch07FunWithQuizzes;

public class TrueFalse : Question
{
    public TrueFalse(string prompt)
        : base(prompt)
    {
        CreateRandomizedChoices([new Choice("True", true), new Choice("False")]);
    }

    public override string ToString()
    {
        string nl = Environment.NewLine;
        return nl + "TRUE OR FALSE:" + nl + Prompt + nl + GetFormattedChoices();
    }
}
