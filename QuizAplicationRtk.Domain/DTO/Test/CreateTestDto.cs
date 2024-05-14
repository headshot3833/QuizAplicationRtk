using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Domain.DTO.Test;

public record CreateTestDto(string Name, string Description, long SubjectId);
