using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Domain.Entity;

public class Test
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public List<Question> Question { get; set; }

    public Subjects Subjects { get; set; }

    public long Subjectid { get; set; }
}
