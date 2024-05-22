using Ch07FunWithQuizzes;

// Diagram: https://tinyurl.com/CSharpCh7StudioFigJam

// BASIC QUIZ

Quiz quiz = new();

string q1Prompt = "Which of the following are books by Jane Austen?";
Choice[] q1Choices =
[
    new Choice("Jane Eyre"),
    new Choice("Pride and Prejudice", true),
    new Choice("Wives and Daughters"),
    new Choice("Mansfield Park", true)
];
Checkbox q1 = new(q1Prompt, q1Choices);

string q2Prompt = "The most-published author of all time is Agatha Christie.";
Choice[] q2Choices = [new Choice("True", true), new Choice("False")];
TrueFalse q2 = new(q2Prompt, q2Choices);

string q3Prompt =
    "Which poem did history-making poet Amanda Gorman recite at the U.S. presidential inauguration in 2021?";
Choice[] q3Choices =
[
    new Choice("The Hill We Climb", true),
    new Choice("The Miracle of Morning"),
    new Choice("We Rise"),
    new Choice("New Day's Lyric")
];
MultipleChoice q3 = new(q3Prompt, q3Choices);

quiz.questions.AddRange([q1, q2, q3]);
quiz.Run();

// BONUS MISSION

// Diagram: https://tinyurl.com/CSharpCh7StudioBonusFigJam

Survey survey = new();

ShortAnswer faveIceCream = new("What is your favorite flavor of ice cream?");
LinearScale vanillaRank = new("How much do you like waffle cones?", 5);
Paragraph toppingsExpo =
    new("Now take a moment to expound upon your favorite ice cream toppings and combinations!");

survey.questions.AddRange([faveIceCream, vanillaRank, toppingsExpo]);
survey.Run();
