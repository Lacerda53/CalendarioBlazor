using CalendarioBlazor.Models;
using System;
using System.Collections.Generic;

namespace CalendarioBlazor.Data._Repositorio.Core
{
    public interface IEventoRepositorio
    {
        void Adicionar(Evento item);
        void Editar(Evento item);
        void Desabilitar(Evento item);
        Evento BuscarPorId(Guid Id);
        IEnumerable<Evento> ListarTodosEventos();
        IEnumerable<Evento> ListarMeusEventos(int UserId);
    }
}
