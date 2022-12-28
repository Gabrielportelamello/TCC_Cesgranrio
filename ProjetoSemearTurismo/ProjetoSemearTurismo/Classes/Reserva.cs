using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSemearTurismo.Classes
{
    public class Reserva
    {
        //- temViagem:bool
        //- temHospedagem:bool
        //- temTransporte:bool
        //- tipoCamaHospedagem:varchar()
        //- numeroQuartoHospedagem:varchar()
        //- numeroAcentoTransporte:varchar()
        //- LocaldeEmbarqueEscolhido:varchar()
        //- preçoViagemCliente() :float
        //- stastusReservaCliente() :varchar()
        //- idPessoa_Reserva_Cliente_FK:int ()
        //- idPessoa_Reserva_Funcionario_FK:()

        public int ID_Reserva { get; set; }
        public bool existeViagem { get; set; }
        public bool existeTransporte{ get; set; }
        public bool existeHospedagem { get; set; }
        public bool existeCliente{ get; set; }
        public string tipoCama { get; set; }
        public string nu_quarto { get; set; }
        public string nu_acentoTransporte{ get; set; }
        public string LocalEmbarque { get; set; }
        public float preçoViagemCliente { get; set; }
        public int StatusReserva { get; set; }
        public int IDCliente { get; set; }
        public int IDFuncionario { get; set; }
        public int formaDePagamento { get; set; }
        public int statusPagamento { get; set; }
        public float SaldoDePagamento { get; set; }
        public string OBSERVACAO { get; set; }

    }
}