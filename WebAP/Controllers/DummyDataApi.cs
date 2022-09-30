using System;

namespace WebAP.Controllers
{
    namespace DummyDataApi.Controllers
    {
        public class UnauthorizedTokenProblemDetails
            : Microsoft.AspNetCore.Mvc.ProblemDetails
        {
            public string IncomingTokenId { get; set; }
            public DateTime Date => DateTime.Now;
        }
    }
}
