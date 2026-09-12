namespace DevQuestion.Domain.Questions;

public class Answer
{
    public Answer(Guid UserId, string Text, Question questions)
    {
        this.UserId = UserId;
        this.Text = Text;
        this.quastion = questions;
    }
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Text { get; set; }
    public Question quastion { get; set; }
    public List<Guid> Comment { get; set; } = [];


}