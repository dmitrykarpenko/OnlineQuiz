using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineQuiz_v02.ViewModels;
using OnlineQuiz_v02.Services;
using Microsoft.Extensions.Configuration;
using OnlineQuiz_v02.Models;
using Microsoft.EntityFrameworkCore;

namespace OnlineQuiz_v02.Controllers.Web
{
    public class AppController : Controller
    {
        private IMailService _mailService;
        private IConfigurationRoot _config;
        private IQuizRepository _repository;

        public AppController(IMailService mailService, IConfigurationRoot config, IQuizRepository repository)
        {
            _mailService = mailService;
            _config = config;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddQuestion()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddQuestion(QuestionVM question)
        {
            _mailService.SendMail(_config["MailSettings:ToAddress"], "test@test.com", "Test subject"
                                , $"Queston statement {question.Statement}");
            return View();
        }

        public IActionResult AllQuestions()
        {
            var questions = _repository.GetAllQuestions(true);

            return View();
        }
    }
}
