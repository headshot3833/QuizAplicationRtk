using Microsoft.EntityFrameworkCore;
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

    public async Task<Subjects> CreateSubject(CreateSubjectDto createSubjectDto)
    {
        
        var Subject = await _SubjectRepository.GetAll().FirstOrDefaultAsync(x => x.Name == createSubjectDto.Name);

        await _SubjectRepository.CreateAsync(Subject);

        return Subject;
    }
}
