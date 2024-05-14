using QuizAplicationRtk.Domain.Entity;
using QuizAplicationRtk.Domain.Interfaces.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Domain.Interfaces.Validations;

public interface ISubjectValidator : IBaseValidator<Subjects>
{
    BaseResult ValidateOnNull(Subjects model);
}
