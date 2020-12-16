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
            string cliente = "Vinicius 21";
            string c1 = "Ana 28";
            string c2 = "Bruno 33";
            string[] vetCliente = { cliente, c1, c2};
            
            return Request.CreateResponse(HttpStatusCode.OK, CadastroClientes.Core.Business.Clientes.ClientesNeg.GetCliente(vetCliente));
        }

    }
}
