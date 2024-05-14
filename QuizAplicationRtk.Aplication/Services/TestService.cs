using Microsoft.EntityFrameworkCore;
using QuizAplicationRtk.Domain.DTO.Test;
using QuizAplicationRtk.Domain.Entity;
using QuizAplicationRtk.Domain.Interfaces.Repositories;
using QuizAplicationRtk.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Aplication.Services;

public class TestService : ICreateTestService
{
    private readonly IBaseRepository<Test> _TestRepository;
    private readonly IBaseRepository<Subjects> _SubjectsRepository;

    public TestService(IBaseRepository<Test> TestRepository, IBaseRepository<Subjects> subjectsRepository)
    {
        _TestRepository = TestRepository;
        _SubjectsRepository = subjectsRepository;
    }

    public async Task<TestDto> CreateTestAsync(CreateTestDto dto)
    {
        var subject = _SubjectsRepository.GetAll().FirstOrDefaultAsync(x => x.Id == x.Id);

        var test = await _TestRepository.GetAll().FirstOrDefaultAsync(x => x.Name == x.Name);

        test = new Test()
        {
            Name = dto.Name,
            Description = dto.Description,
            Subjectid = subject.Id,
        };
        await _TestRepository.CreateAsync(test);
        await _TestRepository.SaveChangesAsync();

        var createtestdto = new CreateTestDto()
        {
            Name = test.Name,
            Description = dto.Description,
            SubjectId = subject.Id,
        };

        throw new Exception();
    }
}
