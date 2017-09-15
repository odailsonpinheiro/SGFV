using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSGFV.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public int Chassis { get; set; }
        public string Placa { get; set; }
        public string Ano { get; set; }
        public string Modelo { get; set; }
        public string Descricao { get; set; }
        public int KmAtual { get; set; }
        public int KmFinal { get; set; }
        public int Situacao { get; set; }




    }
}