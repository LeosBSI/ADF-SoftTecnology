using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TecnologySA.Models
{
    public class Cadastro
    {
        public int ID { get; set; }

        public string Produto { get; set; }

        public double preco { get; set; }

        public string descricao { get; set; }
    }
}