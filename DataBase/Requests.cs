using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RequestsVodokanal.DataBase
{
    public class Requests
    {
        [Key]
        public int Id { get; set; }
        public int State { get; set; }
        public int Contact { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public virtual Contacts ContactMore { get; set; }
        public virtual ICollection<States> States { get; set; }
    }
}
