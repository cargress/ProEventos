﻿using System;
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
    public class EventoController : ControllerBase
    {
        private readonly DataContext context;

        public EventoController(DataContext context)
        {
            this.context = context;

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return context.Eventos;

        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return context.Eventos.Where(evento => evento.EventoId == id);

        }
        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

    }
}
