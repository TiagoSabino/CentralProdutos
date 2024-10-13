using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CentralProdutos.BaseDados.Entidades
{
    [Table("USUARIO")]
    public class USUARIO
    {
        public int ID { get; set; }
        public string NOME { get; set; }
        public string LOGIN { get; set; }
        public string SENHA { get; set; }
    }
}