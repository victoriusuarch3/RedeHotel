using RedeHotel.Lib.Context;
using RedeHotel.Lib.Exceptions;
using RedeHotel.Lib.Interfaces;
using RedeHotel.Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace RedeHotel.Lib.Date.Repository
{
    public class EstadiaRepositorio : BaseRepositorio <Estadia>, IEstadiaRepositorio 
    {
        public EstadiaRepositorio(RedeHotel context) : base ( context, context.Estadias)
        {
            
        }
    }
}