namespace Wiso_Learning_App;
public class Answers
{
    public List<Wiso_A> LoadAnswers()
    {
        var answers = new List<Wiso_A>();

        answers.Add(new Wiso_A()
        {
            Id = answers.Count+1,
            Answers = {}
        });




        return answers;
    }
}
