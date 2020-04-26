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
    public class UsersController : Controller
    {

        private readonly IUserRepository repo;

        public UsersController(IUserRepository r)
        {
            repo = r;
        }
        //User
        [HttpGet]
        public List<User> Get()
        {
            return repo.GetUsers();
        }
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return repo.GetUserId(id);
        }

        [HttpPost]
        public void Create(User user)
        {
            repo.CreateUsers(user);
        }              



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public string Error()
        {
            return "0";
        }
    }
}
