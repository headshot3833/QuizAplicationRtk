using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Domain.Entity;

public class Answers
{
    public int Id { get; set; }

    public string AnswerText { get; set; }

    public bool? IsCorrect {  get; set; }
    public Question Question { get; set; } 
    public Subjects Subjects { get; set; }
    public Test Test {  get; set; }

    
}
