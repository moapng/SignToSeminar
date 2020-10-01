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

        //få fram alla seminars namn
        [HttpGet]
        public IEnumerable<SeminarModel> Get()
        {
            return _context.Seminars.Include(s => s.name).ToArray<SeminarModel>();
        }

        //få fram specifikt seminar mha id
        [HttpGet("{id}")]
        public SeminarModel Get(int id)
        {
            var seminar = _context.Seminars.Where(s => s.id == id).FirstOrDefault();
            if (seminar != null)
                return seminar;
            else
                return null;
        }

        //lägg till seminar
        [HttpPost]
        public void Post([FromBody] SeminarModel seminar)
        {
            _context.Seminars.Add(seminar);
            _context.SaveChanges();
        }

        //ta bort specifikt seminar mha id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var seminar = new SeminarModel { id = id };
            _context.Seminars.Attach(seminar);
            _context.Seminars.Remove(seminar);
            _context.SaveChanges();
        }
    }

}
