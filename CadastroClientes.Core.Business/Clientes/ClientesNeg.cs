using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace CadastroClientes.Core.Business.Clientes
{
    public class ClientesNeg
    {
        //Método para da Get na lista de clientes
        public static List<Models.Clientes.Clientes> GetClientes()
        {
            try
            {
                string path = @"C:\Curso VS\teste\CadastroCliente.Core-API\Arquivos\arq.js";
                List<Models.Clientes.Clientes> listClientes = new List<Models.Clientes.Clientes>();
                string text = File.ReadAllText(path);
                listClientes = JsonConvert.DeserializeObject<List<Models.Clientes.Clientes>>(text);
                return listClientes;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //Método para incluir cliente na lista
        public static void PostCliente(Models.Clientes.Clientes cliente)
        {
            try
            {
                string path = @"C:\Curso VS\teste\CadastroCliente.Core-API\Arquivos\arq.js";
                List<Models.Clientes.Clientes> clientes = new List<Models.Clientes.Clientes>();
                string text = File.ReadAllText(path);
                if (!string.IsNullOrEmpty(text))
                    clientes = JsonConvert.DeserializeObject<List<Models.Clientes.Clientes>>(text);
                if (Util.TamanhoNomeValido(clientes))
                    clientes.Add(cliente);
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(JsonConvert.SerializeObject(clientes));
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }
    }
}
