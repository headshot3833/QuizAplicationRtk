using QuizAplicationRtk.Aplication.Resources;
using QuizAplicationRtk.Domain.Entity;
using QuizAplicationRtk.Domain.Enum;
using QuizAplicationRtk.Domain.Interfaces.Result;
using QuizAplicationRtk.Domain.Interfaces.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Aplication.Validations
{
    public class TestValidator : ITestValidator
    {
        public BaseResult CreateValidator(Subjects subjects, Test test)
        {
            if(subjects == null) 
            {
                return new BaseResult
                {
                    ErrorMessage = ErrorMessage.SubjectNotFound,
                    ErrorCode = (int)ErrorCodes.SubjectNotFound
                };
            }
            if (test != null)
            {
                return new BaseResult
                {
                    ErrorMessage = ErrorMessage.TestAlreadyExist,
                    ErrorCode = (int)ErrorCodes.TestAlreadyExists
                };
            }
            return new BaseResult();
        }

        public BaseResult ValidateOnNull(Test model)
        {
            throw new NotImplementedException();
        }
    }
}
