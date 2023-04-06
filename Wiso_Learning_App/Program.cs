using Newtonsoft.Json;
using Wiso_Learning_App;

var questions = new Questions().LoadQuestions();
var answers = new Answers().LoadAnswers();

var questionString = JsonConvert.SerializeObject(questions, Formatting.Indented);
File.WriteAllText("wiso_Q.json", questionString);

var answerString = JsonConvert.SerializeObject(answers, Formatting.Indented);
File.WriteAllText("wiso_A.json", answerString);

Console.WriteLine();