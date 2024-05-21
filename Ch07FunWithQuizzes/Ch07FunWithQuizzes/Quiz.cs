namespace Ch07FunWithQuizzes;

// For use with Checkbox, MultipleChoice, and TrueFalse type questions

public class Quiz
{
    public readonly List<Question> questions = [];
    public int NumCorrect { get; set; }

    // default constructor is sufficient

    public void RunQuiz() {

        // NOTE: Might be good to shuffle questions first... TODO in future

        foreach (Question question in questions) {
            // Print question and choices for user
            Console.WriteLine(question);

            // Determine correct response(s)
            List<int> correctResponses = [];
            foreach (int choiceNum in question.Choices.Keys) {
                if (question.Choices[choiceNum].Correct) {
                    correctResponses.Add(choiceNum);
                }
            }

            // Get actual response(s) from user & evaluate
            List<int> userResponses = [];
            int i = 0;
            while (i < correctResponses.Count) {
                Console.WriteLine("Please enter a number: ");
                int userResponse = int.Parse(Console.ReadLine());
                if (userResponses.Contains(userResponse)) {
                    Console.WriteLine("You already got that one!");
                } else if (!correctResponses.Contains(userResponse)) {
                    Console.WriteLine("Sorry, the correct answer was: ");
                    foreach (int resp in correctResponses) {
                        Console.WriteLine(question.Choices[resp].Content);
                    }
                    break;
                } else {
                    Console.WriteLine("Correct!");
                    userResponses.Add(userResponse);
                    if (i == correctResponses.Count - 1) {
                        NumCorrect++;
                    }
                    i++;
                }
            }
        }
    }
}
