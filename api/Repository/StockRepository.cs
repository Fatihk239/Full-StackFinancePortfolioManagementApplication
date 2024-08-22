using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
//ctrl + . it give me ability to interface
namespace api.Repository
{
    public class StockRepository : IStockRepository 
    {   
        private readonly ApplicationDBContext _context; 
        public StockRepository(ApplicationDBContext context)
        {
            
            _context = context;  
        }     
        public Task<List<Stock>> GetAllAsync()
        {
            return _context.Stocks.ToListAsync();
        }

        
    }
}