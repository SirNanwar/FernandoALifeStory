using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FernandoALifeStory.Data.Services;
using FernandoALifeStory.Data.Services.Academics;
using FernandoALifeStory.Data.Services.Books;
using FernandoALifeStory.Data.Services.Certifications;
using FernandoALifeStory.Data.Services.Courses;
using FernandoALifeStory.Data.Services.WorkExperiences;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FernandoALifeStory.Web
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddDbContext<FernandoDbContext>(option => {
                option.UseSqlServer(Configuration.GetConnectionString("FernandoDbContext"));
            });
            
            services.AddTransient<ICoursePlatformData, SqlCoursePlatformData>();
            services.AddTransient<ICourseData, SqlCourseData>();

            services.AddTransient<IDegreeData, SqlDegreeData>();
            services.AddTransient<IDisciplineData, SqlDisciplineData>();
            services.AddTransient<IProjectData, SqlProjectData>();

            services.AddTransient<IBookData, SqlBookData>();

            services.AddTransient<IWorkData, SqlWorkData>();
            services.AddTransient<IAchievementData, SqlAchievementData>();

            services.AddTransient<ICertificationData, SqlCertificationData>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", 
                                             pattern: "{controller=Home}/{action=Index}/{id?}");
            });


            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<FernandoDbContext>();
                context.Database.Migrate();
                context.Database.EnsureCreated();
            }
        }
    }
}
