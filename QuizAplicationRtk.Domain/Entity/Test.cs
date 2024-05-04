using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Domain.Entity;

public class Test
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    List<Question> Question { get; set; }

    Subjects Subjects { get; set; }
}
