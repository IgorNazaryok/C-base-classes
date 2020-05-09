using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppServer.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnswersController : Controller
    {
        private readonly IAnswerRepository repo;
        public AnswersController(IAnswerRepository r)
        {
            repo = r;
        }
        
        //Answers
        [HttpGet]
        public List<Answer> Get()
        {
            return repo.GetAnswers();
        }
        [HttpGet("{id}")]
        public List<Answer> Get(int id)
        {
            return repo.GetAnswersIdQuestion(id);
        }
        [HttpPost]
        public void Create(Answer answers)
        {
            repo.CreateAnswer(answers);
        }
        [HttpPut]
        public void Update(Answer answers)
        {
            repo.UpdateAnswer(answers);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public string Error()
        {
            return "0";
        }
    }
}
