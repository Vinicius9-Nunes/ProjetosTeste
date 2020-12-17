using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CadastroCliente.Service.Controllers
{
    [RoutePrefix("api")]
    public class CadastroClienteController : ApiController
    {
        [HttpGet]
        [Route("get")]
        public HttpResponseMessage GetClientes()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, CadastroClientes.Core.Business.Clientes.ClientesNeg.GetClientes());
            }
            catch (Exception e)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, new Exception(e.Message));
            }
        }

        [HttpPost]
        [Route("post")]
        public HttpResponseMessage PostClientes([FromBody] CadastroClientes.Core.Models.Clientes.Clientes cliente)
        {
            try
            {
                CadastroClientes.Core.Business.Clientes.ClientesNeg.PostCliente(cliente);
                string sucesso = "Cliente Cadastrado com sucesso";
                return Request.CreateResponse(HttpStatusCode.OK, sucesso);
            }
            catch (Exception e)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, new Exception(e.Message));
            }
        }

    }
}
