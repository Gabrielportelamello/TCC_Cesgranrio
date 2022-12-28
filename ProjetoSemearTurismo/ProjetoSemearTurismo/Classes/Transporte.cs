using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSemearTurismo
{
    public class csTransporte
    {

        public int ID_Transporte { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Telefones { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public int QTD_Assentos { get; set; }
        public string Locais_embarque { get; set; }
        public string itinerario { get; set; }
        public float Preco { get; set; }
    }
}