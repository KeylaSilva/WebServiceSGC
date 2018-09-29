using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAGestaoCursos.Models
{
    public class AutenticarSaida : Aluno
    {
        public bool Sucesso { get; set; }
        public string Erro { get; set; }
    }
}