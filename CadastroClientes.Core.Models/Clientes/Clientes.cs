using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroClientes.Core.Models.Clientes
{
    public class Clientes
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Clientes(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
