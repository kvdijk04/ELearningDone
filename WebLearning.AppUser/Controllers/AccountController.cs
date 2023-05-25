﻿using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using WebLearning.ApiIntegration.Services;
using WebLearning.Contract.Dtos.Account;

namespace WebLearning.AppUser.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IConfiguration _configuration;
        private readonly ILoginService _loginService;
        private readonly IAccountService _accountService;

        private readonly INotyfService _notyf;

        public AccountController(ILogger<AccountController> logger, ILoginService loginService, IConfiguration configuration, IAccountService accountService
                                , INotyfService notyfService)
        {
            _logger = logger;
            _loginService = loginService;
            _configuration = configuration;
            _accountService = accountService;
            _notyf = notyfService;
        }
        [Route("/tai-khoan-cua-toi.html")]
        public async Task<ActionResult<UserAllInformationDto>> Dashboard()
        {
            var token = HttpContext.Session.GetString("Token");

            if (token == null)
            {
                return Redirect("/dang-nhap.html");
            }

            var account = await _accountService.GetAccountByEmail(User.Identity.Name);

            if (account.ReportScoreCourseDtos == null && account.ReportScoreLessionDtos == null && account.ReportScoreMonthlyDtos == null)
            {
                return View(account);
            }
            return View(account);
        }
    }
}