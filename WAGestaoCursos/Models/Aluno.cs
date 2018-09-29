using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAGestaoCursos.Models
{
    public class Aluno
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}