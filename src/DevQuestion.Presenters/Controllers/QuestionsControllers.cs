using DevQuestion.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace DevQuestion.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class QuestionsController : ControllerBase
{
    //     {
    //   "title": "string",
    //   "body": "string",
    //   "userId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
    //   "tagIds": [
    //     "3fa85f64-5717-4562-b3fc-2c963f66afa6"
    //              ]
    //      }
    [HttpPost]
    public async Task<IActionResult> Create(
        [FromBody] CreatedQuestionDto createdQuestionDto,
        CancellationToken cancellationToken)
    {
        return Ok("Questions");
    }

    [HttpGet]
    public async Task<IActionResult> Get(
        [FromQuery] GetQuestionsDto getQuestionsDto,
        CancellationToken cancellationToken)
    {
        return Ok("Questions Get");
    }

    [HttpGet("{questionId:guid}")]
    public async Task<IActionResult> GetById(
        [FromRoute] Guid questionId,
        CancellationToken cancellationToken)
    {
        return Ok("Question get");
    }

    [HttpPut("{questionId:guid}")]
    public async Task<IActionResult> Update(
        [FromRoute] Guid questionId,
        [FromBody] UpdateQuestionsDto updateQuestionsDto,
        CancellationToken cancellationToken)
    {
        return Ok("Question updated");
    }

    [HttpDelete("{questionId:guid}")]
    public async Task<IActionResult> Delete(
        [FromRoute] Guid questionId,
        CancellationToken cancellationToken)
    {
        return Ok("Question deleted");
    }

    [HttpPut("{questionId:guid}/solution")]
    public async Task<IActionResult> Selectsolution(
        [FromRoute] Guid questionId,
        [FromQuery] Guid answerId,
        CancellationToken cancellationToken)
    {
        return Ok("solution selected");
    }

    [HttpPost("{questionId:guid}/answers")]
    public async Task<IActionResult> AddAnswer(
        [FromRoute] Guid questionId,
        [FromBody] AddAnswerDto addAnswerDto,
        CancellationToken cancellationToken)
    {
        return Ok("solution selected");
    }



}


