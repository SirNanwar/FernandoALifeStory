using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FernandoALifeStory.Data.Services;
using FernandoALifeStory.Data.Services.Academics;
using FernandoALifeStory.Data.Services.Books;
using FernandoALifeStory.Data.Services.Certifications;
using FernandoALifeStory.Data.Services.Courses;
using FernandoALifeStory.Data.Services.Infos;
using FernandoALifeStory.Data.Services.WorkExperiences;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FernandoALifeStory.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<FernandoDbContext>(option => {
                option.UseSqlServer(Configuration.GetConnectionString("FernandoDbContext"));
                });


            services.AddTransient<INfoData, SqlInfoData>();
            services.AddTransient<IContactInfoData, SqlContactInfoData>();
            services.AddTransient<ISocialMediaInfoData, SqlSocialMediaInfoData>();

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

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
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
