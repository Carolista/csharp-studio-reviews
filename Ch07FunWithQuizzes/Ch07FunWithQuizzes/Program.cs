using Ch07FunWithQuizzes;


// BASIC QUIZ

Quiz quiz = new();

string q1 = "Which of the following are books by Jane Austen?";
Choice[] q1Choices = [
        new Choice("Jane Eyre"),
        new Choice("Pride and Prejudice", true),
        new Choice("Wives and Daughters"),
        new Choice("Mansfield Park", true)
];
Checkbox question1 = new(q1, q1Choices);

String q2 = "The most-published author of all time is Agatha Christie.";
Choice[] q2Choices = [
        new Choice("True", true),
        new Choice("False")
];
TrueFalse question2 = new(q2, q2Choices);

String q3 = "Which poem did history-making poet Amanda Gorman recite at the U.S. presidential inauguration in 2021?";
Choice[] q3Choices = [
        new Choice("The Hill We Climb", true),
        new Choice("The Miracle of Morning"),
        new Choice("We Rise"),
        new Choice("New Day's Lyric")
];
MultipleChoice question3 = new(q3, q3Choices);

quiz.questions.AddRange([question1, question2, question3]);

quiz.RunQuiz();

Console.WriteLine(Environment.NewLine + 
    "You answered " + quiz.NumCorrect + " of " + quiz.questions.Count +
    " questions correctly. Thanks for playing!" + Environment.NewLine);


// TODO: BONUS MISSION
