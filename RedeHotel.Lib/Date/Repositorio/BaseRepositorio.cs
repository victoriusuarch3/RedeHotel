using RedeHotel.Lib.Context;
using RedeHotel.Lib.Exceptions;
using RedeHotel.Lib.Interfaces;
using RedeHotel.Lib.Models;
using Microsoft.EntityFrameworkCore;
namespace RedeHotel.Lib.Date.Repository
{
    public class BaseRepositorio <T> : IBaseRepositorio <T> where T : ModelBase
    {
        protected readonly RedeHotelContext _context;
        protected readonly DbSet<T> _dbset;
        public BaseRepositorio(RedeHotelContext dbContext, DbSet<T> dbset)
        {
            _context = dbContext;
            _dbset = dbset;
        }
    }
}