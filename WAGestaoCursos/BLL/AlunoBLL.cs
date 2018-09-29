using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAGestaoCursos.DAL;
using WAGestaoCursos.Models;

namespace WAGestaoCursos.BLL
{
    public class AlunoBLL
    {
        public static IEnumerable<Aluno> BuscarTodosAlunos()
        {
            return AlunoDAL.BuscarTodosAlunos();
        }
        public static Aluno Autenticar(AutenticarEntrada autenticarEntrada)
        {
            return AlunoDAL.AutenticarDAL(autenticarEntrada);
        }
    }
}