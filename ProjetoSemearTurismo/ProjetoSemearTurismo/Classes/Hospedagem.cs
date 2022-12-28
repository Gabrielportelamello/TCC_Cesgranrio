using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSemearTurismo.Classes
{
    public class Hospedagem
    {
        //        - ID_Hospdagem:int
        //- ID_Pessoa:int
        //- Nome:varchar()
        //- Endereco :varchar()
        //- CNPJ:varchar()
        //- Telfones:varchar()
        //- Email:varchar()
        //- CEP:varchar()
        //- QTD_Quartos:int
        //- QTD_Camas:int
        //- Tipo_cama:varchar()
        //- pacotes_inclusos:varchar()
        //- Data_checkin:DATETIME
        //- Data_checkout:DATETIME
        //- Preço:Float
        public int ID_Hospdagem { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string CNPJ { get; set; }
        public string Telfones { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public int qtd_quartos { get; set; }
        public int qtd_camas { get; set; }
        public string tipo_cama { get; set; }
        public string pacote_incluso { get; set; }
        public DateTime data_checkin { get; set; }
        public DateTime data_checkout { get; set; }
        public float preco { get; set; }
    }
}