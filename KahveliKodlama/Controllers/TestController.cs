using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Service.Contract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KahveliKodlama.API.Controllers
{
    public class TestController : Controller
    {
        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<string> GetStudent()
        {
            var result =await _testService.GetById(1);
            return result.Grade.GradeName;
        }
    }
}
