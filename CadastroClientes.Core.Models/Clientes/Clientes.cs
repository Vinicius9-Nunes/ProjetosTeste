﻿namespace CadastroClientes.Core.Models.Clientes
{
    public class Clientes
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }

        public Clientes(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
