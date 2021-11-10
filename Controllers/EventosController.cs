using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        public DataContext Context { get; }
        public EventosController(DataContext context)
        {
            this.Context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get() => this.Context.Eventos;

        [HttpGet("{id}")]
        public Evento GetById(int id) => this.Context.Eventos.FirstOrDefault(x => x.EventoId == id);

        [HttpPost]
        public string Post() => "Exemplo de post";
    }
}
