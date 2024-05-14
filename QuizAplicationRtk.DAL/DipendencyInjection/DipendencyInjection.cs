using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuizAplicationRtk.DAL.Repositories;
using QuizAplicationRtk.Domain.DTO.Subject;
using QuizAplicationRtk.Domain.DTO.Test;
using QuizAplicationRtk.Domain.Entity;
using QuizAplicationRtk.Domain.Interfaces.Repositories;
using QuizAplicationRtk.Domain.Interfaces.Services;
using QuizAplicationRtk.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.DAL.DipendencyInjection;

public static class DipendencyInjection
{
    public static void AddDataAccessLayer(this IServiceCollection services, IConfiguration configuration )
    {
        var connectionString = configuration.GetConnectionString(name: "DeffaultString");

        services.AddDbContext<ApplicationDbContext>(optionsAction: options =>
        {
            options.UseNpgsql(connectionString);
        });
        services.InitRepositories();
    }

    private static void InitRepositories(this IServiceCollection services)
    {
        services.AddScoped<IBaseRepository<Subjects>, BaseRepository<Subjects>>();

        services.AddScoped<IBaseRepository<Test>, BaseRepository<Test>>();
    }
}
