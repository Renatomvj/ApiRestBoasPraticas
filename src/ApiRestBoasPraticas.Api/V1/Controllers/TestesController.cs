using ApiRestBoasPraticas.Api.Controllers;
using ApiRestBoasPraticas.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestBoasPraticas.Api.V1.Controllers
{
    
    [ApiVersion("1.0", Deprecated = true)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TestesController : MainController
    {
        public TestesController(INotificador notificador) : base(notificador)
        {
        }

        [HttpGet]
        public string Versao() => "Versão 1";
    }
}
