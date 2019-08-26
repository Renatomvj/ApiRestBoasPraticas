using ApiRestBoasPraticas.Api.Controllers;
using ApiRestBoasPraticas.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestBoasPraticas.Api.V2.Controllers
{
    [ApiVersion("2.0")]   
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TestesController : MainController
    {
        public TestesController(INotificador notificador) : base(notificador)
        {
        }

        [HttpGet]
        public string Versao() => "Versão 2";
    }
}
