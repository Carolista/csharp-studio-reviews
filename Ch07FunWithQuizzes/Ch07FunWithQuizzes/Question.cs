﻿using System.Text;

namespace Ch07FunWithQuizzes;

public class Question
{
    public string Prompt { get; set; }
    public Dictionary<int, Choice> Choices { get; set; } = [];

    public Question(string prompt, Choice[] choiceArr)
    {
        Prompt = prompt;
        CreateRandomizedChoices(choiceArr);
    }

    public void CreateRandomizedChoices(Choice[] choiceArr) {
        Random.Shared.Shuffle(choiceArr);
        List<Choice> choiceList = [.. choiceArr];
        for (int i=0; i < choiceList.Count; i++) {
            Choices.Add(i+1, choiceList[i]);
        }
    }

    public string GetFormattedChoices() {
        StringBuilder formattedChoices = new StringBuilder();
        foreach (int choiceNum in Choices.Keys) {
            string choice = "\t" + choiceNum + " - " + Choices[choiceNum].Content + Environment.NewLine;
            formattedChoices.Append(choice);
        }
        return formattedChoices.ToString();
    }
    
}
