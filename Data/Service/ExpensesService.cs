﻿using FinanceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Data.Service
{
    public class ExpensesService : IExpensesService
    {
        private readonly FinanceAppContext _context;
        public ExpensesService(FinanceAppContext context)
        {
            _context = context;
        }
        public async Task Add(Expense expense)
        {
            _context.Expenses.Add(expense);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var expense = await _context.Expenses.FindAsync(id);
            if (expense != null)
            {
                _context.Expenses.Remove(expense);
                await _context.SaveChangesAsync();
            }
        }


        public async Task<IEnumerable<Expense>> GetAll()
        {
            var expenses = await _context.Expenses.ToListAsync();
            return expenses;
        }

        public IQueryable GetChartData()
        {
            var data = _context.Expenses
                              .GroupBy(e => e.Category)
                              .Select(g => new
                              {
                                  Category = g.Key,
                                  Total = g.Sum(e => e.Amount)
                              });
            return data;
        }

        public async Task<decimal> GetTotalExpenses()
        {
            return await _context.Expenses.SumAsync(e => (decimal)e.Amount);
        }

    }
}