namespace DevQuestion.Contracts;

//     {
//   "title": "string",
//   "bode": "string",
//   "userId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
//   "tagIds": [
//     "3fa85f64-5717-4562-b3fc-2c963f66afa6"
//   ]
// }
public record CreateQueastionsDto(string Title, string Text, Guid UserId, Guid[] TagIds);

//GET /questions?tag_id=1&page=1&limit=10&title="test"
public record GetQueastionsDto(string Search, Guid[] TagIds, int PageSize, int Limit);

//     {
//   "title": "string",
//   "bode": "string",
//   "tagIds": [
//     "3fa85f64-5717-4562-b3fc-2c963f66afa6"
//   ]
// }
public record UpdateQuestionDto(string Title, string Bode, Guid[] TagIds);

//PUT /questions/{question_id}/answers
// {
//     "body": "This is a comments"
//     "user_id": 1.
//    
// }
public record AddAnswerDto(Guid UserId, string Text);