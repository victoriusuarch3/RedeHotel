using RedeHotel.Lib.Date;
using RedeHotel.Lib.Date.Repository;
using RedeHotel.Lib.Interfaces;
using RedeHotel.Lib.Models;

namespace DoDevHotel.Lib.Date.Repository
{
    public class HospedeRepositorio : BaseRepositorio<Hospede>, IHospedeRepositorio
{
        public HospedeRepositorio(RedeHotelContext context) : base(context, context.Hospedes)
        {

        }
    }
}