using RedeHotel.Lib.Context;
using RedeHotel.Lib.Exceptions;
using RedeHotel.Lib.Interfaces;
using RedeHotel.Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace RedeHotel.Lib.Date.Repository
{
    public class Servicos_x_HoteisRepositorio : BaseRepositorio<Servicos_x_Hoteis>, IServicos_x_HoteisRepositorio
    {
        public Servicos_x_HoteisRepositorio(RedeHotelContext context) : base (context, context.Servicos_x_Hoteis)
        {
            
        }   
    }
}