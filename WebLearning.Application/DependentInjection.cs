﻿using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WebLearning.Application.Services;
using WebLearning.Application.Validation;
using WebLearning.Contract.Dtos;
using WebLearning.Contract.Dtos.Course;
using WebLearning.Contract.Dtos.Course.CourseAdminView;
using WebLearning.Contract.Dtos.Lession;
using WebLearning.Contract.Dtos.Lession.LessionAdminView;
using WebLearning.Contract.Dtos.Question.QuestionCourseAdminView;
using WebLearning.Contract.Dtos.Question.QuestionLessionAdminView;
using WebLearning.Contract.Dtos.Question.QuestionMonthlyAdminView;
using WebLearning.Contract.Dtos.Quiz;
using WebLearning.Persistence.ApplicationContext;

namespace WebLearning.Application
{
    public static class DependentInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WebLearningContext>(options => options.UseSqlServer(configuration.GetConnectionString("WebLearningConnection")
                                                      , o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)));
            //services.AddFluentValidationAutoValidation();
            //services.AddScoped<IValidator<CreateUserDto>, CreateUserValidator>();
            //services.AddScoped<IValidator<UpdateUserDto>, UpdateUserValidator>();
            services.AddScoped<IAccountService, AccountService>();

            services.AddScoped<IAnswerCourseService, AnswerCourseService>();

            services.AddScoped<IAnswerLessionService, AnswerLessionService>();

            services.AddScoped<IAnswerMonthlyService, AnswerMonthlyService>();

            services.AddScoped<ICourseService, CourseService>();

            services.AddScoped<ICourseRoleService, CourseRoleService>();

            services.AddScoped<IOptionLessionService, OptionLessionService>();

            services.AddScoped<IOptionCourseService, OptionCourseService>();

            services.AddScoped<IOptionMonthlyService, OptionMonthlyService>();


            services.AddScoped<ICorrectAnswerService, CorrectAnswerService>();

            services.AddScoped<ICorrectAnswerCourseService, CorrectAnswerCourseService>();

            services.AddScoped<ICorrectAnswerMonthlyService, CorrectAnswerMonthlyService>();


            services.AddScoped<IHistorySubmitCourseService, HistorySubmitCourseService>();

            services.AddScoped<IHistorySubmitLessionService, HistorySubmitLessionService>();

            services.AddScoped<IHistorySubmitMonthlyService, HistorySubmitMonthlyService>();

            services.AddScoped<ILessionService, LessionService>();

            services.AddScoped<ILoginService, LoginService>();

            services.AddScoped<IQuestionCourseService, QuestionCourseService>();

            services.AddScoped<IQuestionLessionService, QuestionLessionService>();

            services.AddScoped<IQuestionMonthlyService, QuestionMonthlyService>();

            services.AddScoped<IQuizCourseService, QuizCourseService>();

            services.AddScoped<IQuizLessionService, QuizLessionService>();

            services.AddScoped<IQuizMonthlyService, QuizMonthlyService>();

            services.AddScoped<IReportScoreCourseService, ReportScoreCourseService>();

            services.AddScoped<IReportScoreLessionService, ReportScoreLessionService>();

            services.AddScoped<IReportScoreMonthlyService, ReportScoreMonthlyService>();

            services.AddScoped<IStorageService, StorageService>();

            services.AddScoped<IRoleService, RoleService>();

            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<IImportExcelService, ImportExcelService>();

            services.AddScoped<IBookingService, BookingService>();

            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();


            //Validation
            services.AddScoped<IValidator<CreateCourseDto>, CreateCourseValidation>();
            services.AddScoped<IValidator<UpdateCourseAdminView>, UpdateCourseValidation>();
            services.AddScoped<IValidator<CreateLessionAdminView>, CreateLessionValidation>();
            services.AddScoped<IValidator<UpdateLessionDto>, UpdateLessionValidation>();


            services.AddScoped<IValidator<CreateQuizLessionDto>, CreateQuizLessionValidation>();
            services.AddScoped<IValidator<CreateQuizCourseDto>, CreateQuizCourseValidation>();
            services.AddScoped<IValidator<CreateQuizMonthlyDto>, CreateQuizMonthlyValidation>();

            services.AddScoped<IValidator<UpdateQuizLessionDto>, UpdateQuizLessionValidation>();
            services.AddScoped<IValidator<UpdateQuizCourseDto>, UpdateQuizCourseValidation>();
            services.AddScoped<IValidator<UpdateQuizMonthlyDto>, UpdateQuizMonthlyValidation>();

            services.AddScoped<IValidator<CreateAllConcerningQuestionLessionDto>, CreateQuestionLessionValidation>();
            services.AddScoped<IValidator<CreateAllConcerningQuestionCourseDto>, CreateQuestionCourseValidation>();
            services.AddScoped<IValidator<CreateAllConcerningQuestionMonthlyDto>, CreateQuestionMonthlyValidation>();

            services.AddScoped<IValidator<UpdateAllConcerningQuestionLesstionDto>, UpdateQuestionLessionValidation>();
            services.AddScoped<IValidator<UpdateAllConcerningQuestionCourseDto>, UpdateQuestionCourseValidation>();
            services.AddScoped<IValidator<UpdateAllConcerningQuestionMonthlyDto>, UpdateQuestionMonthlyValidation>();
            //Config AppSetting
            services.Configure<AppSetting>(configuration.GetSection("AppSettings"));

            var secretKey = configuration["AppSettings:SecretKey"];
            var secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);


            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(opt =>
                {
                    opt.TokenValidationParameters = new TokenValidationParameters
                    {
                        //tự cấp token
                        ValidateIssuer = false,
                        ValidateAudience = false,

                        //ký vào token
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(secretKeyBytes),

                        ClockSkew = TimeSpan.Zero,

                        ValidateLifetime = false,
                    };
                });

            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            });


            return services;
        }
    }
}