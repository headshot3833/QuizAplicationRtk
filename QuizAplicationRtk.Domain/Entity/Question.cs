using QuizAplicationRtk.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Domain.Entity;

public class Question
{
    public int Id { get; set; }

    public string QuestionText { get; set; }

    public Test Test { get; set; }

    List<Answers> Answers { get; set; }
    public AnswerType AnswerType { get; set; }

}
