using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppServer.Models
{
    public class Voice
    {
        public int Id { get; set; }
        public int AnswerId { get; set; }
        public string UserName { get; set; }
    }
}
