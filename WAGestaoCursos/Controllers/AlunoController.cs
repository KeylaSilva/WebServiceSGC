using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WAGestaoCursos.BLL;
using WAGestaoCursos.Models;

namespace WAGestaoCursos.Controllers
{
    [RoutePrefix("api/Alunos")]
    public class AlunoController : ApiController
    {
        /// <summary>
        /// Buscar todos Alunos
        /// </summary>
        /// <remarks>Buscar todos os alunos</remarks>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        [AllowAnonymous]
        [AcceptVerbs("GET")]
        [Route("BuscarAlunos")]
        // GET: api/Employees  
        public IEnumerable<Aluno> BuscarAlunos()
        {
            AlunoBLL alunoBll = new AlunoBLL();
            return AlunoBLL.BuscarTodosAlunos();
        }

        /// <summary>
        /// Realizar a Autenticação do Aluno
        /// </summary>
        /// <param name="autenticar">Objeto utilizado para autenticação</param>
        /// <remarks>Autenticar Usuário</remarks>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        [AllowAnonymous]
        [Route("AutenticarAluno")]
        // GET api/values/5
        public Aluno AutenticarAluno(AutenticarEntrada autenticar)
        {
            AlunoBLL alunoBll = new AlunoBLL();
            return AlunoBLL.Autenticar(autenticar);
        }        
    }
}
