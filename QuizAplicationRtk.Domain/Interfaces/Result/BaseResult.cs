using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Domain.Interfaces.Result;

public class BaseResult
{
    public bool IsSuccess => ErrorMessage == null;

    public string ErrorMessage {  get; set; }

    public int? ErrorCode { get; set; }
}
