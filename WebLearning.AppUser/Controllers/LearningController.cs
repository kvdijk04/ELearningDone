﻿using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebLearning.ApiIntegration.Services;
using WebLearning.AppUser.Models;

namespace WebLearning.AppUser.Controllers
{
    public class LearningController : Controller
    {
        private readonly ILogger<LearningController> _logger;
        private readonly IAccountService _accountService;

        private readonly INotyfService _notyf;
        public LearningController(ILogger<LearningController> logger, INotyfService notyf, IAccountService accountService)

        {
            _logger = logger;
            _notyf = notyf;
            _accountService = accountService;
        }
        [Authorize]
        [Route("elearning.html")]
        public async Task<IActionResult> Index(DashboardViewModel dasboardModel)
        {
            var account = await _accountService.GetAccountByEmail(User.Identity.Name);

            var token = HttpContext.Session.GetString("Token");

            if (token == null)
            {
                return Redirect("/dang-nhap.html");
            }

            dasboardModel.CourseDtos = account.CourseDtos.ToList();

            dasboardModel.LessionDtos = account.LessionDtos.ToList();

            dasboardModel.QuizlessionDtos = account.QuizlessionDtos.ToList();

            dasboardModel.OwnCourseDtos = account.OwnCourseDtos.ToList();


            dasboardModel.ReportScoreLessionDtos = account.ReportScoreLessionDtos.ToList();

            dasboardModel.ReportScoreCourseDtos = account.ReportScoreCourseDtos.ToList();

            dasboardModel.ReportScoreMonthlyDtos = account.ReportScoreMonthlyDtos.ToList();


            return View(dasboardModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Route("/khong-tim-thay-trang.html")]
        public IActionResult NoneExist()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}