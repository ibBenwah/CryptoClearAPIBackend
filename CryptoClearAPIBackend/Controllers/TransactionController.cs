using CryptoClearAPIBackend.DbModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace CryptoClearAPIBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly CryptoClearDbContext _context; 

        public TransactionController(CryptoClearDbContext context)
        {
            _context = context;
        }

        [HttpGet("transactions")]
        public async Task<ActionResult<IEnumerable<Transaction>>> GetEvents()
        {
            return await _context.Transaction.ToListAsync();
        }




    }
}
