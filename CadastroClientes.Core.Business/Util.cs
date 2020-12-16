using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroClientes.Core.Business
{
    class Util
    {
        public static bool TamanhoNomeValido(List<Models.Clientes.Clientes> clientes)
        {
            const int _tamanhoMaximoNome = 20;
            foreach (Models.Clientes.Clientes c in clientes)
            {
                if (string.IsNullOrEmpty(c.Nome))
                    throw new Exception("Nome não informado");
                if (c.Nome.Length > _tamanhoMaximoNome)
                    throw new Exception("Nome informado esta muito longo:\n" + c.Nome);
            }
            return true;
        }
    }
}
