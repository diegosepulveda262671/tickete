using Microsoft.EntityFrameworkCore;
using Ticket.API.Services;
using Ticket.Shared.Entities;
using Ticket.Shared.Enums;
using Ticket.Shared.Responses;

namespace Ticket.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IApiService _apiService;
  

        public SeedDb(DataContext context, IApiService apiService)
        {
            _context = context;
            _apiService = apiService;
           
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
         
        }




        private async Task CheckCountriesAsync()
        {
            if (!_context.Ticketes.Any())

            {
                for(var x = 1; x <= 50000; x++)
                {
                    _context.Ticketes.Add(new Tickete());
                }

              
                await _context.SaveChangesAsync();

             
                
            }
        }
    }
}
