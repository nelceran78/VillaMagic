using System.Net;

namespace MagicVilla_API.Modelos
{
    public class APIResponse
    {
        public APIResponse()
        {
            ErrorMensages = new List<string> ();
        }
        public HttpStatusCode  statusCode { get; set; }

        public bool IsExitoso { get; set; } = true;

        public List<string> ErrorMensages { get; set; }

        public object Resultado { get; set; }

    }
}
