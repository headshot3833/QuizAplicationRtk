using QuizAplicationRtk.Domain.DTO.Subject;
using QuizAplicationRtk.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Domain.Interfaces.Services;

public interface ICreateSubjectServices
{
    Task<Subjects> CreateSubject(CreateSubjectDto createSubjectDto);
}
