namespace Ch07FunWithQuizzes;

public class LinearScale : Question
{
    public int HighestNum { get; set; }

    public LinearScale(string prompt, int highestNum)
        : base(prompt)
    {
        HighestNum = highestNum;
    }

    public override string ToString()
    {
        string nl = Environment.NewLine;
        return nl + Prompt + nl + "Please enter a number from 1 to " + HighestNum + ":" + nl;
    }
}
