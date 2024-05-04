using FonTech.Domain.Dto.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuizAplicationRtk.Domain.Interfaces.Repositories;
using QuizAplicationRtk.Domain.Interfaces.Result;
using QuizAplicationRtk.Domain.Interfaces.Services;
using QuizAplicationRtk.Domain.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Aplication.Services;

public class AuthService : IAuthServices
{
    private readonly IBaseRepository<User> _UserRepository;

    public AuthService(IBaseRepository<User> userRepository)
    {
        _UserRepository = userRepository;
    }

    public Task<UserDto> Login(LoginUserDto loginUserDto)
    {
        throw new NotImplementedException();
    }
}
