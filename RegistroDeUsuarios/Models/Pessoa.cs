using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeUsuarios.Models
{
    public class Pessoa
    {
        private int ID { get; set; }
        private string Name { get; set; }
        private string Email { get; set; }
        public string Phone { get; set; }
    }
}
