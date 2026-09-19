using System.Security.Cryptography.X509Certificates;
using DevQuestion.Contracts;
using FluentValidation;

namespace DevQuestions.Application.Questions;

public class CreateQuestionsValidator : AbstractValidator<CreateQueastionsDto>
{
    public CreateQuestionsValidator()
    {
        RuleFor(x => x.Title).NotEmpty().MaximumLength(500).WithMessage("Заголовок невалидный");
        RuleFor(x => x.Text).NotEmpty().MaximumLength(500).WithMessage("Текст невалидный");
        RuleFor(x => x.UserId).NotEmpty();
    }
}