﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InnovateTaskBack.Models;

namespace InnovateTaskBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceDetailsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InvoiceDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/InvoiceDetails1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoiceDetails>>> GetInvoiceDetails()
        {
            return await _context.InvoiceDetails.ToListAsync();
        }

        // GET: api/InvoiceDetails1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InvoiceDetails>> GetInvoiceDetails(int id)
        {
            var invoiceDetails = await _context.InvoiceDetails.FindAsync(id);

            if (invoiceDetails == null)
            {
                return NotFound();
            }

            return invoiceDetails;
        }

        // PUT: api/InvoiceDetails1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvoiceDetails(int id, InvoiceDetails invoiceDetails)
        {
            if (id != invoiceDetails.Id)
            {
                return BadRequest();
            }

            _context.Entry(invoiceDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoiceDetailsExists(id))
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

        // POST: api/InvoiceDetails1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<InvoiceDetails>> PostInvoiceDetails(InvoiceDetails invoiceDetails)
        {
            _context.InvoiceDetails.Add(invoiceDetails);
            await _context.SaveChangesAsync();            
            return CreatedAtAction("GetInvoiceDetails", new { id = invoiceDetails.Id }, invoiceDetails);
        }

        // DELETE: api/InvoiceDetails1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvoiceDetails(int id)
        {
            var invoiceDetails = await _context.InvoiceDetails.FindAsync(id);
            if (invoiceDetails == null)
            {
                return NotFound();
            }

            _context.InvoiceDetails.Remove(invoiceDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InvoiceDetailsExists(int id)
        {
            return _context.InvoiceDetails.Any(e => e.Id == id);
        }
    }
}
