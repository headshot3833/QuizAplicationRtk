using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QuizAplicationRtk.Aplication.Resources;
using QuizAplicationRtk.Domain.DTO.Subject;
using QuizAplicationRtk.Domain.Entity;
using QuizAplicationRtk.Domain.Enum;
using QuizAplicationRtk.Domain.Interfaces.Repositories;
using QuizAplicationRtk.Domain.Interfaces.Result;
using QuizAplicationRtk.Domain.Interfaces.Services;
using QuizAplicationRtk.Domain.Interfaces.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Aplication.Services;

public class SubjectService : ICreateSubjectServices
{
    private readonly IBaseRepository<Subjects> _SubjectRepository;
    private readonly ISubjectValidator _subjectValidator;

    public SubjectService(IBaseRepository<Subjects> subjectRepository, ISubjectValidator subjectValidator)
    {
        _SubjectRepository = subjectRepository;
        _subjectValidator = subjectValidator;
    }

    public async Task<BaseResult<SubjectDto>> CreateSubject(SubjectDto createSubjectDto)
    {
        try
        {
            var Subject = await _SubjectRepository.GetAll().FirstOrDefaultAsync(x => x.Name == createSubjectDto.Name);

            var result = _subjectValidator.ValidateOnNull(Subject);
        }
        catch (Exception ex)
        {
            return new BaseResult<SubjectDto>()
            {
                ErrorMessage = ErrorMessage.InternalServerError,
                ErrorCode = (int)ErrorCodes.InternalServerError
            };
        }
        return ;
    }

    public async Task<SubjectDto> GetSubjectAsync(long id)
    {
        SubjectDto? subjects;

        subjects = _SubjectRepository.GetAll()
            .AsEnumerable()
            .Select(x => new SubjectDto(x.Id, x.Name)).FirstOrDefault(x => x.Id == id);

        return subjects;
    }
}
