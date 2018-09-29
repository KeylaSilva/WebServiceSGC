using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WAGestaoCursos.Models;

namespace WAGestaoCursos.DAL
{
    public class AlunoDAL
    {
        public static AutenticarSaida AutenticarDAL(AutenticarEntrada autenticar)
        {
            AutenticarSaida alunoAutenticado = new AutenticarSaida();

            try
            {
                using (var db = new SGCEntities())
                {
                    var alunoRetorno = db.ALUNOS.Where(x => db.ALUNOS.Count(e => e.EMAIL_ALUNO == autenticar.Login) > 0 && x.SENHA_ALUNO.ToLower() == autenticar.Senha).FirstOrDefault();
                    if (alunoRetorno != null)
                    {
                        alunoAutenticado = ConverterAlunoAutenticado(alunoRetorno);
                        alunoAutenticado.Sucesso = true;
                    }

                    return alunoAutenticado;
                }
            }
            catch (Exception ex)
            {
                alunoAutenticado.Sucesso = false;
                alunoAutenticado.Erro = ex.Message;
                return alunoAutenticado;
            }
        }

        internal static IEnumerable<Aluno> BuscarTodosAlunos()
        {
            List<Aluno> listRetornoAlunos = new List<Aluno>();
            try
            {
                using (var db = new SGCEntities())
                {
                    var alunosRetorno = db.ALUNOS;

                    if (alunosRetorno.Any())
                    {
                        foreach (var itemAluno in alunosRetorno)
                        {
                            listRetornoAlunos.Add(ConverterAluno(itemAluno));
                        }
                    }

                    return listRetornoAlunos;
                }
            }
            catch (Exception ex)
            {
                return listRetornoAlunos;
            }
        }

        private static Aluno ConverterAluno(ALUNOS aluno)
        {
            Aluno alunoConvertido = new Aluno();
            if (aluno != null)
            {
                alunoConvertido.Cpf = aluno.CPF_ALUNO;
                alunoConvertido.Email = aluno.EMAIL_ALUNO;
                alunoConvertido.Endereco = aluno.END_ALUNO;
                alunoConvertido.Estado = aluno.ESTADO_ALUNO;
                alunoConvertido.Municipio = aluno.MUNICIPIO_ALUNO;
                alunoConvertido.Nome = aluno.NOME_ALUNO;
                alunoConvertido.Telefone = aluno.TEL_ALUNO;
            }

            return alunoConvertido;
        }

        private static AutenticarSaida ConverterAlunoAutenticado(ALUNOS aluno)
        {
            AutenticarSaida alunoConvertido = new AutenticarSaida();
            if (aluno != null)
            {
                alunoConvertido.Cpf = aluno.CPF_ALUNO;
                alunoConvertido.Email = aluno.EMAIL_ALUNO;
                alunoConvertido.Endereco = aluno.END_ALUNO;
                alunoConvertido.Estado = aluno.ESTADO_ALUNO;
                alunoConvertido.Municipio = aluno.MUNICIPIO_ALUNO;
                alunoConvertido.Nome = aluno.NOME_ALUNO;
                alunoConvertido.Telefone = aluno.TEL_ALUNO;
            }

            return alunoConvertido;
        }

    }
}