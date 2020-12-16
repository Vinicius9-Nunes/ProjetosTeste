using System;
using System.Collections.Generic;


namespace CadastroClientes.Core.Business.Clientes
{
    public class ClientesNeg
    {
        public static List<Models.Clientes.Clientes> GetCliente(string[] cliente)
        {
            List<Models.Clientes.Clientes> listClientes = new List<Models.Clientes.Clientes>();
            string[] aux;
            if (cliente.Length > 0)
            {
                foreach (string s in cliente)
                {
                    aux = s.Split(',');
                    string nome = aux[0];
                    int idade = int.Parse(aux[1]);
                    if (Util.TamanhoNomeValido(listClientes))
                    {
                        Models.Clientes.Clientes c = new Models.Clientes.Clientes(nome, idade);
                        listClientes.Add(c);
                    }
                }
                return listClientes;
            }
            else
                throw new ApplicationException("Não foi informado nenhum Cliente");

        }
    }
}
