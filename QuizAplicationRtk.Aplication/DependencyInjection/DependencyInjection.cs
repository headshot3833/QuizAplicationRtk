using Microsoft.Extensions.DependencyInjection;
using QuizAplicationRtk.Aplication.Services;
using QuizAplicationRtk.Domain.DTO.Subject;
using QuizAplicationRtk.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Aplication.DependencyInjection;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        InitService(services);
    }
    private static void InitService(this IServiceCollection services)
    {
       services.AddScoped<ICreateTestService, TestService>();
       services.AddScoped<ICreateSubjectServices, SubjectService>();
    }

}
