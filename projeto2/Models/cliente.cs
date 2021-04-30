using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace projeto2.Models
{
    public class cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Endereco { get; set; }
    }
}