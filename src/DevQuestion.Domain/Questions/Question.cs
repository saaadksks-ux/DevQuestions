using System.Diagnostics;

namespace DevQuestion.Domain.Questions;

public class Question
{
    public Question(Guid Id, string Title, string Text, Guid UserId, Guid ScreenshotsId, IEnumerable<Guid> Tags)
    {
        this.Id = Id;
        this.Title = Title;
        this.Text = Text;
        this.UserId = UserId;
        this.ScreenshotsId = ScreenshotsId;
        this.Tags = Tags.ToList();
    }
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public Guid UserId { get; set; }
    public Guid ScreenshotsId { get; set; }
    public List<Answer> answers { get; set; } = [];
    public Answer? Solution { get; set; }
    public IEnumerable<Guid> Tags { get; set; } = [];
    public QuestionStatus status { get; set; } = QuestionStatus.Open;


}
