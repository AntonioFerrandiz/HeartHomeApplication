using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HeartHome.Data;
using HeartHome.Entities;
using HeartHome.Web.Models;

namespace HeartHome.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountsController : ControllerBase
    {
        private readonly DbContextHeartHomeApp _context;

        public BankAccountsController(DbContextHeartHomeApp context)
        {
            _context = context;
        }

        // GET: api/BankAccounts
        [HttpGet]
        public async Task<IEnumerable<BankAccountModel>> GetBankAccounts()
        {
            var bankAccountsList = await _context.BankAccounts.ToListAsync();

            return bankAccountsList.Select(c => new Models.BankAccountModel
            {
                BankAccountID = c.BankAccountID,
                BankID = c.BankID,
                AccountNumber = c.AccountNumber,
                DateExpiration = c.DateExpiration,
                CVC = c.CVC
            });
        }

        // GET: api/BankAccounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BankAccount>> GetBankAccount(int id)
        {
            var bankAccount = await _context.BankAccounts.FindAsync(id);

            if (bankAccount == null)
            {
                return NotFound();
            }

            return bankAccount;
        }

        // PUT: api/BankAccounts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBankAccount(int id, BankAccount bankAccount)
        {
            if (id != bankAccount.BankAccountID)
            {
                return BadRequest();
            }

            _context.Entry(bankAccount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BankAccountExists(id))
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

        // POST: api/BankAccounts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BankAccount>> PostBankAccount(BankAccount bankAccount)
        {
            _context.BankAccounts.Add(bankAccount);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBankAccount", new { id = bankAccount.BankAccountID }, bankAccount);
        }

        // DELETE: api/BankAccounts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBankAccount(int id)
        {
            var bankAccount = await _context.BankAccounts.FindAsync(id);
            if (bankAccount == null)
            {
                return NotFound();
            }

            _context.BankAccounts.Remove(bankAccount);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BankAccountExists(int id)
        {
            return _context.BankAccounts.Any(e => e.BankAccountID == id);
        }
    }
}
