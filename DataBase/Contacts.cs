using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RequestsVodokanal.DataBase
{
    public class Contacts
    {
        [Key]
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public ICollection<Requests> Requests { get; set; }
    }
}
