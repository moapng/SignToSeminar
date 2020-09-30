using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignToSeminarBackEnd.Context;
using SignToSeminarBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignToSeminarBackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SeminarController : ControllerBase
    {

        private readonly STSDBContext _context;
        public SeminarController(STSDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<SeminarModel> Get()
        {
            return _context.Seminars.Include(s => s.name).ToArray<SeminarModel>();
        }
    }
    
}
