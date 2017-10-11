using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSGFV.Models
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }
        public int Chassis { get; set; }
        public string Placa { get; set; }
        public string AnoFabricacao { get; set; }
        public string Modelo { get; set; }
        public string Descricao { get; set; }
        public int KmAtual { get; set; }
        public int KmFinal { get; set; }
        public bool Situacao { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public virtual ICollection<RetiradaVeiculo> RetiradaVeiculos { get; set; }




    }
}