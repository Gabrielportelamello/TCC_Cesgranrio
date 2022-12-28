using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSemearTurismo.Classes
{
    public class Viagem
    {
        //        ID_Viagem:int
        //- ID_Transporte:int
        //- ID_Pessoa:int
        //- ID_Hospedagem:int
        //- Nome_do_pacote:varchar()
        //- período_da_viagem:DATETIME
        //- descricao_do_pacote:varchar()
        //- Tipo_Transporte:vatchar()
        //- Preço:float
        //- formas_de_pagamento:varchar()
        public int ID_Viagem { get; set; }
        public string Nome_do_pacote { get; set; }
        public DateTime DInicialPeriodo_viagem { get; set; }
        public DateTime DFinalperiodo_viagem { get; set; }
        public string Descricao_do_pacote { get; set; }
        public string Tipo_Transporte { get; set; }
        public float Preco { get; set; }
        public string Formas_de_pagamento { get; set; }
        public string OBSERVACAO { get; set; }
    }
}