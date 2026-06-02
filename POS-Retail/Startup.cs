using BAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository;
using UnitofWork;

namespace SchoolManagementSystem
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddControllersWithViews();
            services.AddDbContext<SchoolManagementContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUnitofWork, Unitofwork>();
            services.AddScoped<IExamService, ExamService>();
            services.AddScoped<IExamRepository<Exam>, ExamRepository>();
            services.AddScoped<IfeeService, FeeService>();
            services.AddScoped<IFeeRepository<Fee>, FeeRepository>();
            services.AddScoped<IStudentService,StudentService>();
            services.AddScoped<IStudentRepository<Student>, StudentRepository>();
            services.AddScoped<IAttandanceService, AttandanceService>();
            services.AddScoped<IAttandanceRepository<Attandance>, AttandanceRepository>();

            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<ITeacherRepository<Teacher>, TeacherRepository>();

            services.AddScoped<ITimeTableService, TimeTableService>();
            services.AddScoped<ITimeTableRepository<TimeTable>, TimeTableRepository>();


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

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
        }
    }
}