using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.CommandHandlers;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Bus;
using CleanArch.Infra.Data.Context;
using CleanArch.Infra.Data.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection services)
        {

            //DOmain InmemoryBus
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain handler
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

            // Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Infra data layer
            services.AddScoped<ICoursesRepository, CourseRepository>();

            services.AddScoped<UniversityDBContext>();

        }
    }
}
