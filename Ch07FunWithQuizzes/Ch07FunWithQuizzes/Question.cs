using System.Text;

namespace Ch07FunWithQuizzes;

public abstract class Question
{
    public string Prompt { get; set; }
    public Dictionary<int, Choice> Choices { get; set; } = [];

    public Question(string prompt, Choice[] choiceArr)
    {
        Prompt = prompt;
        CreateRandomizedChoices(choiceArr);
    }

    // Bonus mission: Use secondary constructor to bypass choiceArr
    public Question(string prompt)
        : this(prompt, []) { }

    public void CreateRandomizedChoices(Choice[] choiceArr)
    {
        Random.Shared.Shuffle(choiceArr);
        List<Choice> choiceList = [.. choiceArr];
        for (int i = 0; i < choiceList.Count; i++)
        {
            Choices.Add(i + 1, choiceList[i]);
        }
    }

    public string GetFormattedChoices()
    {
        StringBuilder formattedChoices = new StringBuilder();
        foreach (int choiceNum in Choices.Keys)
        {
            string choice =
                "\t" + choiceNum + " - " + Choices[choiceNum].Content + Environment.NewLine;
            formattedChoices.Append(choice);
        }
        return formattedChoices.ToString();
    }

    public abstract override string ToString();
}
