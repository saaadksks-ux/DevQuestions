using DevQuestion.Contracts;

namespace DevQuestion.Application.Questions;

public interface IQuestionService
{
    Task<Guid> CreateI(
        CreateQueastionsDto createQueastionsDto,
        CancellationToken cancellationToken);
}