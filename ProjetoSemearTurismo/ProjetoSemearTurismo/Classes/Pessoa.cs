using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSemearTurismo
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public DateTime Data_Nascimento { get; set; }
        public string CPF { get; set; }
        public string Passaporte { get; set; }
        public DateTime emissao_passaporte { get; set; }
        public DateTime Validade_Passaporte { get; set; }
        public string RG { get; set; }
        public string orgao_emissor_RG { get; set; }
        public string data_emissao_RG { get; set; }
        public string endereco { get; set; }
        public string CEP { get; set; }
        public string Perfil_Acesso { get; set; }

        public Pessoa(string nome, string telefone, string email, DateTime data_nascimento, string CPF, string passaporte,
            DateTime emissao_passaporte, DateTime Validade_Passaporte,
            string RG, string orgao_emissor_RG, string data_emissão_RG, string endereco, 
            string CEP, string Perfil_Acesso) 
        {
            this.Nome = nome;
        }
      
       
    }
    public class Fucionario : Pessoa
    {
        public Fucionario (Pessoa pessoa, int ID_Funcionario, float salario): base (pessoa.Nome, pessoa.Telefone, pessoa.Email,
            pessoa.Data_Nascimento,pessoa.CPF, pessoa.Passaporte, pessoa.emissao_passaporte,pessoa.Validade_Passaporte,
            pessoa.RG,pessoa.orgao_emissor_RG, pessoa.data_emissao_RG,pessoa.endereco,pessoa.CEP,pessoa.Perfil_Acesso)
        {
            this.ID_Funcionario = ID_Funcionario;
            this.salario = salario;
        }
        public Fucionario(Pessoa pessoa) : base(pessoa.Nome, pessoa.Telefone, pessoa.Email, pessoa.Data_Nascimento, 
            pessoa.CPF, pessoa.Passaporte, pessoa.emissao_passaporte, pessoa.Validade_Passaporte,
            pessoa.RG, pessoa.orgao_emissor_RG, pessoa.data_emissao_RG, pessoa.endereco, pessoa.CEP, pessoa.Perfil_Acesso)
        {

        }
        public int ID_Funcionario { get; set; }
        public float salario { get; set; }


       
    }
    public class Cliente : Pessoa 
    {
        public Cliente(Pessoa pessoa, int ID_Cliente, int formaDePagamento, float Saldo) : base( pessoa.Nome, pessoa.Telefone, pessoa.Email, pessoa.Data_Nascimento, pessoa.CPF, pessoa.Passaporte, pessoa.emissao_passaporte, pessoa.Validade_Passaporte,
           pessoa.RG, pessoa.orgao_emissor_RG, pessoa.data_emissao_RG, pessoa.endereco, pessoa.CEP, pessoa.Perfil_Acesso)
        {
            this.ID_Cliente = ID_Cliente;
            this.Saldo = Saldo;
        }
        public Cliente(Pessoa pessoa) : base(pessoa.Nome, pessoa.Telefone,
            pessoa.Email, pessoa.Data_Nascimento, pessoa.CPF, pessoa.Passaporte,
            pessoa.emissao_passaporte, pessoa.Validade_Passaporte,
           pessoa.RG, pessoa.orgao_emissor_RG, pessoa.data_emissao_RG,
           pessoa.endereco, pessoa.CEP, pessoa.Perfil_Acesso)
        {

        }
        public int ID_Cliente{ get; set; }
        public float Saldo { get; set; }


    }
}