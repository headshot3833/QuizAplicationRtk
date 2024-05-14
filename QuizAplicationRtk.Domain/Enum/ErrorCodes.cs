using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Domain.Enum
{
    public enum ErrorCodes
    {
        TestNotFound = 1,
        TestAlreadyExists = 2,
        TestNotExists = 3,

        SubjectNotFound = 10,
        SubjectAlreadyExists = 11,

        InternalServerError = 20,
    }
}
