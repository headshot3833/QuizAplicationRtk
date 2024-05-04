using FonTech.Domain.Dto.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Domain.Interfaces.Services;

public interface IAuthServices
{
    Task<UserDto> Login(LoginUserDto loginUserDto);
}
