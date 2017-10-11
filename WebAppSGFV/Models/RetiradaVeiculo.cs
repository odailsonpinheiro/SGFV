using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSGFV.Models
{
    public class RetiradaVeiculo
    {
        public int RetiradaVeiculoId { get; set; }
        public Boolean Status { get; set; }
        public int VeiculoId { get; set; }
        public Veiculo Veiculo  { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataPrevistaRetorno { get; set; }
        public DateTime DataEntrega { get; set; }
        public decimal KmAtual { get; set; }
        public decimal KmDevolucao { get; set; }

    }
}