using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Domain
{
    public class Cinema
    {

        [Key]
        public int Id { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }

        //Relations
        public List<Movie> Movies { get; set; }
    }
}
