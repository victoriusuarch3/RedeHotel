using RedeHotel.Lib.Context;
using RedeHotel.Lib.Exceptions;
using RedeHotel.Lib.Interfaces;
using RedeHotel.Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace RedeHotel.Lib.Date.Repository
{
    public class Estadias_x_HospedeRepositorio : BaseRepositorio<EstadiasXHospedeRepositorio>, IEstadiasXHospedeRepositorio
    {
        public Estadias_x_HospedeRepositorio(RedeHotelContext context) : base (context, context.EstadiasXHospedes)
        {
            
        }
    }
}