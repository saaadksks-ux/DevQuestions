using DevQuestion.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace DevQuestion.Presenters;

[ApiController]
[Route("[controller]")]

public class QuestionsController : ControllerBase
{
    //     {
    //   "title": "string",
    //   "bode": "string",
    //   "userId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
    //   "tagIds": [
    //     "3fa85f64-5717-4562-b3fc-2c963f66afa6"
    //   ]
    // }
    [HttpPost]
    public async Task<IActionResult> Create(
        [FromBody] CreateQueastionsDto createQueastionsDto,
        CancellationToken cancellationToken)
    {
        return Ok("Question create");
    }

    //GET /questions?tag_id=1&page=1&limit=10&title="test"
    [HttpGet]
    public async Task<IActionResult> Get(
        [FromQuery] GetQueastionsDto getQuestionsDto,
        CancellationToken cancellationToken)
    {
        return Ok("Question get");
    }

    //GET /questions/{question_id}
    [HttpGet("{questionId:guid}")]
    public async Task<IActionResult> GetById(
        [FromRoute] Guid questionId,
        CancellationToken cancellationToken)
    {
        return Ok("Question get");
    }

    //     {
    //   "title": "string",
    //   "bode": "string",
    //   "tagIds": [
    //     "3fa85f64-5717-4562-b3fc-2c963f66afa6"
    //   ]
    // }
    [HttpPut("{questionId:guid}")]
    public async Task<IActionResult> Update(
        [FromRoute] Guid questionId,
        [FromBody] UpdateQuestionDto updateQuestionDto,
        CancellationToken cancellationToken)
    {
        return Ok("Question updated");
    }

    //DELETE /questions/{question_id}
    [HttpDelete("{questionId:guid}")]
    public async Task<IActionResult> Delete(
        [FromRoute] Guid questionId,
        CancellationToken cancellationToken)
    {
        return Ok("Question delete");
    }

    //PUT /questions/{question_id}/comments
    // {
    //     "user_id": 1.
    //     "body": "This is a comments"
    // }
    [HttpPut("{questionId:guid}/solution")]
    public async Task<IActionResult> SelectSolution(
        [FromRoute] Guid questionId,
        [FromQuery] Guid answerId,
        CancellationToken cancellationToken)
    {
        return Ok("Solution selected");
    }
    //POST /questions/{question_id}/answers
    // {
    //     "body": "This is a comments"
    //     "user_id": 1.
    //    
    // }
    [HttpPost("{questionId:guid}/answers")]
    public async Task<IActionResult> AddAnswer(
        [FromRoute] Guid questionId,
        [FromBody] AddAnswerDto addAnswerDto,
        CancellationToken cancellationToken)
    {
        return Ok("Answer added");
    }

}

