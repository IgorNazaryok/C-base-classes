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
    public class QuestionsController : Controller
    {
        private readonly IQuestionRepository repo;
        public QuestionsController(IQuestionRepository r)
        {
            repo = r;
        }
        
        //Questions
        [HttpGet]
        public List<Question> Get()
        {
            return repo.GetQuestions();
        }
        [HttpGet("{id}")]
        public Question Get(int id)
        {
            return repo.GetQuestionId(id);
        }
        [HttpPost]
        public Question Create(Question questions)
        {
            return repo.CreateQuestion(questions);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repo.DeleteQuestion(id);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public string Error()
        {
            return "0";
        }
    }
}
