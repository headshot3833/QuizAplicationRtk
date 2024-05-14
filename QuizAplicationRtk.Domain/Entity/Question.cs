using QuizAplicationRtk.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Domain.Entity;

public class Question
{
    public long Id { get; set; }

    public string QuestionText { get; set; }

    public Test TestId { get; set; }
    public Subjects SubjectsId { get; set; }
    List<Answers> Answers { get; set; }

}
