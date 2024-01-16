using SalesWebMvc.Data;
using SalesWebMvc.Models;
using Microsoft.EntityFrameworkCore;
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

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            try
            {
                obj.Department = _context.Department.First();
                _context.Add(obj);
                _context.SaveChanges();
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
    }
}
