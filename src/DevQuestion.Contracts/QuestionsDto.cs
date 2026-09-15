namespace DevQuestion.Contracts;

public record CreateQueastionsDto(string Title, string Bode, Guid UserId, Guid[] TagIds);
public record GetQueastionsDto(string Search, Guid[] TagIds, int PageSize, int Limit);
public record UpdateQuestionDto(string Title, string Bode, Guid[] TagIds);
public record AddAnswerDto(Guid UserId, string Text);