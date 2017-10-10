using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSGFV.Models
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Cpf { get; set; }
        public int Matricula { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public string Funcao { get; set; }
        public string Telefone { get; set; }

    }
}