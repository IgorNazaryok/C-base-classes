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
    public class VotesController : Controller
    {
        private readonly IVotesRepository repo;
        public VotesController(IVotesRepository r)
        {
            repo = r;
        }
        
        
        [HttpGet]
        public List<Voice> Get()
        {
            return repo.GetVotes();
        }
        [HttpGet("{id}")]
        public List<string> GetUsers(int id)
        {
            return repo.GetUserVotesAnswerId(id);
        }
        [HttpGet("10/{id}")]
        public int GetNumberUser(int id)
        {
            return repo.GetNumberUserVotesAnswerId(id);
        }
        [HttpPost]
        public void Create(Voice voice)
        {
            repo.CreateVoice(voice);
        }
              
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public string Error()
        {
            return "0";
        }
    }
}
