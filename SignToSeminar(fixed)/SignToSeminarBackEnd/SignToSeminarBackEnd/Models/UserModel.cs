using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignToSeminarBackEnd.Models
{
    public class UserModel
    {
        public int id { get; set; }
        public string emailAdress { get; set; }
        public string password { get; set; }
        public SeminarModel[] listOfBookedSeminars { get; set; }
    }
}
