namespace DevQuestion.Contracts;

public record CreatedQuestionDto(string Title, String Body, Guid UserId, Guid[] TagIds);

public record GetQuestionsDto(string Search, Guid[] TagIds, int PageSize, int Limit);

public record UpdateQuestionsDto(string Title, String Body, Guid[] TagIds);
public record AddAnswerDto(Guid UserId, string Test);
