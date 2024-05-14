using QuizAplicationRtk.Domain.Entity;
using QuizAplicationRtk.Domain.Interfaces.Result;
using QuizAplicationRtk.Domain.Interfaces.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Aplication.Validations
{
    public class SubjectValidator : ISubjectValidator
    {
        public BaseResult ValidateOnNull(Subjects model)
        {
            throw new NotImplementedException();
        }
    }
}
