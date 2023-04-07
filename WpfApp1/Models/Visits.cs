using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Visits
    {
        [Key]
        public int Id { get; set; }
        public int AnketaId { get;set; }
        public string Comment { get; set; }
        public string Files { get;set; } = "";
        public DateTime Time { get; set; } = DateTime.Now;
    }
}
