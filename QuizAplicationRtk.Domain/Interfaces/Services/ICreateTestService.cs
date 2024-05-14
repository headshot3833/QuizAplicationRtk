using QuizAplicationRtk.Domain.DTO.Test;
using QuizAplicationRtk.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Domain.Interfaces.Services
{
    public interface ICreateTestService
    {
        /// <summary>
        /// Создание теста для тестирования
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<TestDto> CreateTestAsync(CreateTestDto dto);
    }
}
