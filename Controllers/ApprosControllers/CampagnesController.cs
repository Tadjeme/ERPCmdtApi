using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ERPCmdtApi.ApprosDbContext;
using aApprosModels.ModelsBase;
using AutoMapper;
using ERPCmdtApi.ViewModelsAppro;

namespace ERPCmdtApi.Controllers.ApprosControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampagnesController : ControllerBase
    {
        private readonly ERPCmdtApi.ApprosDbContext.ApprosDbContext _context;
        private readonly IMapper _mapper;

        public CampagnesController(ERPCmdtApi.ApprosDbContext.ApprosDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Campagnes
        [HttpGet]
        public async Task<ActionResult<List<CampagneVm>>> GetCampagnes()
        {
            var campagnes = await _context.Campagnes.ToListAsync();
            var campagnesVm = _mapper.Map<List<CampagneVm>>(campagnes);
            return (campagnesVm);
               
              
        }

        // GET: api/Campagnes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CampagneVm>> GetCampagne(Guid id)
        {
            var campagne = await _context.Campagnes.FindAsync(id);
            
            if (campagne == null)
            {
                return NotFound();
            }
            var campagneVm = _mapper.Map<CampagneVm>(campagne);
            return campagneVm;
        }

        // PUT: api/Campagnes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCampagne(Guid id, CampagneVm campagneVm)
        {

            if (id != campagneVm.Id)
            {
                return BadRequest();
            }

            var campagne = _mapper.Map<Campagne>(campagneVm);
            campagne.LastModifiedDate = DateTime.Now;
            _context.Entry(campagne).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CampagneExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Campagnes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CampagneVm>> PostCampagne(CampagneVm campagneVm)
        {
            var campagne = _mapper.Map<Campagne>(campagneVm);
            campagne.Id = Guid.NewGuid();
            campagne.CreatedDate = DateTime.Now;
            _context.Campagnes.Add(campagne);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCampagne", new { id = campagneVm.Id }, campagneVm);
        }

        // DELETE: api/Campagnes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCampagne(Guid id)
        {
            var campagne = await _context.Campagnes.FindAsync(id);
            if (campagne == null)
            {
                return NotFound();
            }

            //_context.Campagnes.Remove(campagne);
            campagne.IsDeleted = true;
            campagne.LastModifiedDate = DateTime.Now;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CampagneExists(Guid id)
        {
            return _context.Campagnes.Any(e => e.Id == id);
        }
    }
}
