using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Domain.Interfaces.Interfaces;

public interface IStateSaveChanges
{
    Task<int> SaveChangesAsync();
}
