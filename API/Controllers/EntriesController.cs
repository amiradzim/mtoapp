using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntriesController : ControllerBase
    {
        private readonly DataContext _context;
        public EntriesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MtoEntries>>> GetEntries()
        {
            var entries = await _context.Entries.ToListAsync();

            return entries;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MtoEntries>> GetEntry(int id)
        {
            return await _context.Entries.FindAsync(id);
        }
    }
}