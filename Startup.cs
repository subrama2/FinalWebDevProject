using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalWebDevProject.Controllers;
using FinalWebDevProject.Info;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FinalWebDevProject
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
        {
			Configuration = configuration;
        }

		public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CoursesDbContext>(o => o.UseSqlServer(Configuration.GetConnectionString("CoursesDatabase")));

            services.AddSingleton<IcourseDataAccess, CourseDataAccess>();
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
        }
    }
	}

