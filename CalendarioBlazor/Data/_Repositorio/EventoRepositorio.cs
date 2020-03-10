using CalendarioBlazor.Data._Infra;
using CalendarioBlazor.Data._Repositorio.Core;
using CalendarioBlazor.Models;
using Dapper;
using System;
using System.Collections.Generic;

namespace CalendarioBlazor.Data._Repositorio
{
    public class EventoRepositorio : IEventoRepositorio
    {
        private IDB DB;
        public EventoRepositorio(IDB _dB)
        {
            DB = _dB;
        }
        public void Adicionar(Evento item)
        {
            using(var con = DB.GetConnection())
            {
                var query = "INSERT INTO [Evento]    " +
                            "           ([Id]		 " +
                            "           ,[Nome]		 " +
                            "           ,[Descricao] " +
                            "           ,[Inicio]	 " +
                            "           ,[Fim]		 " +
                            "           ,[Cor]		 " +
                            "           ,[Habilitado]" +
                            "           ,[DiaInteiro]" +
                            "           ,[UsuarioId])" +
                            "     VALUES			 " +
                            "           (@Id		 " +
                            "           ,@Nome		 " +
                            "           ,@Descricao	 " +
                            "           ,@Inicio	 " +
                            "           ,@Fim		 " +
                            "           ,@Cor		 " +
                            "           ,@Habilitado " +
                            "           ,@DiaInteiro " +
                            "           ,@UsuarioId) ";
                con.Execute(query, item);
            }
        }

        public Evento BuscarPorId(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Desabilitar(Evento item)
        {
            throw new NotImplementedException();
        }

        public void Editar(Evento item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Evento> ListarMeusEventos(int UserId)
        {
            using (var con = DB.GetConnection())
            {
                var query = "select * from Evento where UsuarioId=@UserId and Habilitado = 1";
                return con.Query<Evento>(query, new { UserId });
            }
        }

        public IEnumerable<Evento> ListarTodosEventos()
        {
            using (var con = DB.GetConnection())
            {
                var query = "select * from Evento where Habilitado = 1";
                return con.Query<Evento>(query);
            }
        }
    }
}
