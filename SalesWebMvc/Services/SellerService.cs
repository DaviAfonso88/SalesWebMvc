using SalesWebMvc.Models;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Services.Exceptions;
using SalesWebMvc.Data;
using Microsoft.Data.SqlClient;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }

        public async Task InsertAsync(Seller obj)
        {
            try
            {
                _context.Add(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                // Log the exception or output to console
                Console.WriteLine("Error saving changes: " + e.Message);

                // Check if it's a specific database exception
                if (e.InnerException is SqlException sqlException)
                {
                    // Log or handle specific database exception details
                    Console.WriteLine("SQL Exception Number: " + sqlException.Number);
                }

                // Rethrow the exception for higher-level handling if needed
                throw;
            }
            catch (Exception ex)
            {
                // Log the exception or output to console
                Console.WriteLine("Error saving changes: " + ex.Message);

                // Rethrow the exception for higher-level handling if needed
                throw;
            }
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {

            try
            {
                var obj = await _context.Seller.FindAsync(id);
                _context.Seller.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException(e.Message);
            }

        }

        public async Task UpdateAsync(Seller obj)
        {
            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}