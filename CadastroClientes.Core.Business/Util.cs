using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroClientes.Core.Business
{
    class Util
    {
        public static bool TamanhoNomeValido(Models.Clientes.Clientes cliente)
        {
            const int _tamanhoMaximoNome = 20;
            
                if (string.IsNullOrEmpty(cliente.Nome))
                    throw new Exception("Nome não informado");
                if (cliente.Nome.Length > _tamanhoMaximoNome)
                    throw new Exception("Nome informado esta muito longo: " + cliente.Nome);
            return true;
        }
    }
}
