using QuizAplicationRtk.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Domain.Entity;

public class Answers
{
    public long Id { get; set; }

    public string AnswerText { get; set; }

    public bool? IsCorrect {  get; set; }
    public Question QuestionId { get; set; } 
    public Subjects SubjectsId { get; set; }
    public Test TestId {  get; set; }
    public AnswerType AnswerType { get; set; }

}
