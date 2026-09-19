//using System.ComponentModel.DataAnnotations;
using DevQuestion.Contracts;
using DevQuestion.Domain.Questions;
using DevQuestions.Application.Quaestions;
using FluentValidation;
using Microsoft.Extensions.Logging;
namespace DevQuestion.Application;



public class QuestionsService : IQuestionsService
{


    private readonly IQuestionsRepository _questionsRepository;
    private readonly IValidator<CreateQueastionsDto> _validator;
    private readonly ILogger _logger;
    //консруктор QuestionsService для внедрения зависимостей IQuestionsRepository, IValidator<CreateQueastionsDto> и ILogger<QuestionsService>
    public QuestionsService(
        IQuestionsRepository questionsRepository,
        IValidator<CreateQueastionsDto> validator,
        ILogger<QuestionsService> logger)
    {
        _questionsRepository = questionsRepository;
        _validator = validator;
        _logger = logger;
    }



    /////////////////////проверка валидности/////////////////////
    /////////////////////Валидация входных данных/////////////////////
    public async Task<Guid> Create(
            CreateQueastionsDto createQueastionsDto,
            CancellationToken cancellationToken)
    {
        /////////////////////проверка валидности/////////////////////

        var validationResult = await _validator.ValidateAsync(createQueastionsDto, cancellationToken);

        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }


        /////////////////////оздание сущности Questions/////////////////////
        ////////////////////////Валидация бизнес логики/////////////////////
        /// 
        int openUserQuestionsCount = await _questionsRepository
            .GetOpenUserQuestionsAsync(createQueastionsDto.UserId, cancellationToken);

        if (openUserQuestionsCount >= 3)
        {
            throw new Exception("Юзер не может открыть больше 3 вопросов");
        }

        var questionId = Guid.NewGuid();
        var question = new Question(

            questionId,
            createQueastionsDto.Title,
            createQueastionsDto.Text,
            createQueastionsDto.UserId,
            Guid.Empty,
            createQueastionsDto.TagIds.ToList());

        /////////////////////Сохранение сужностей Quaestions в бвзе данный/////////////////////

        await _questionsRepository.AddAsync(question, cancellationToken);


        /////////////////////логирование об успешном или не успешном логгировании /////////////////////

        _logger.LogInformation("Question created with id {QuestionId}", questionId);
        return questionId;
    }

    // public async Task<IActionResult> Update(
    //     Guid questionId,
    //     UpdateQuestionDto updateQuestionDto,
    //     CancellationToken cancellationToken)
    // {

    // }

    // public async Task<IActionResult> Delete(
    //     Guid questionId,
    //     CancellationToken cancellationToken)
    // {

    // }

    // public async Task<IActionResult> SelectSolution(
    //     Guid questionId,
    //     Guid answerId,
    //     CancellationToken cancellationToken)
    // {

    // }

    // public async Task<IActionResult> AddAnswer(
    //     Guid questionId,
    //     AddAnswerDto addAnswerDto,
    //     CancellationToken cancellationToken)
    // {

    // }
}

public interface IQuestionsService
{
}