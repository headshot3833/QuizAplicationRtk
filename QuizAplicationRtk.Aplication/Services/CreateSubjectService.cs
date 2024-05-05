using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QuizAplicationRtk.Domain.DTO.Subject;
using QuizAplicationRtk.Domain.Entity;
using QuizAplicationRtk.Domain.Interfaces.Repositories;
using QuizAplicationRtk.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Aplication.Services;

public class CreateSubjectService : ICreateSubjectServices
{
    private readonly IBaseRepository<Subjects> _SubjectRepository;

    public CreateSubjectService(IBaseRepository<Subjects> subjectRepository)
    {
        _SubjectRepository = subjectRepository;
    }

    public async Task<SubjectDto> CreateSubject(SubjectDto createSubjectDto)
    {
        
        var Subject = await _SubjectRepository.GetAll().FirstOrDefaultAsync(x => x.Name == createSubjectDto.Name);

        Subject = new Subjects()
        {
            Name = createSubjectDto.Name,
        };
        await _SubjectRepository.CreateAsync(Subject);
        await _SubjectRepository.SaveChangesAsync();

        return createSubjectDto;
    }

    public Task<SubjectDto> GetSubjectAsync(long id)
    {
        SubjectDto? subjects;

        subjects = _SubjectRepository.GetAll()
            .AsEnumerable()
            .Select(x => new SubjectDto(x.Id, x.Name)).FirstOrDefault(x => x.id == id);

        return Task.FromResult(subjects);
    }
}
