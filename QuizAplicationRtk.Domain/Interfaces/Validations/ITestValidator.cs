using QuizAplicationRtk.Domain.Entity;
using QuizAplicationRtk.Domain.Interfaces.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Domain.Interfaces.Validations;

public interface ITestValidator : IBaseValidator<Test>
{
    /// <summary>
    /// проверяется наличие субьекта при создании, теста
    /// </summary>
    /// <param name="subjects"></param>
    /// <param name="test"></param>
    /// <returns></returns>
    BaseResult CreateValidator(Subjects subjects, Test test);
}
