using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RequestsVodokanal.DataBase
{
    public class States
    {
        [Key]
        public int Id { get; set; }
        public int Request { get; set; }
        public int State { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public virtual ICollection<Requests> Requests { get; set; }
    }
}
