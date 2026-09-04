using Microsoft.AspNetCore.Mvc;
using NimbusBank.Backend.Data;
using NimbusBank.Backend.Models;

namespace NimbusBank.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoanController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LoanController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(LoanApplication model)
        {
            _context.LoanApplications.Add(model);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}