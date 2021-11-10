using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
                EventoId = 1,
                Tema = "Angular 11", 
                Local = "1 lote", 
                QtdPessoas = "250", 
                DataEvento = DateTime.Now.AddDays(2).ToString(), 
                ImagemURL = "http://www.google.com.br"
            },
            new Evento(){
                EventoId = 2,
                Tema = "Angular 12", 
                Local = "2 lote", 
                QtdPessoas = "350", 
                DataEvento = DateTime.Now.AddDays(1).ToString(), 
                ImagemURL = "http://www.google.com.brrrrrrr"
            },
        };
        public EventoController()
        {
        }
        [HttpGet]
        public IEnumerable<Evento> Get() => _evento;

        [HttpGet("{id}")]
        public Evento GetById(int id) => _evento.FirstOrDefault(x => x.EventoId == id);

        [HttpPost]
        public string Post() => "Exemplo de post";
    }
}
