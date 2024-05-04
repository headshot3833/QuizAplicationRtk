using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Domain.Users
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Role {  get; set; }
        public string Password { get; set; }
    }
}
