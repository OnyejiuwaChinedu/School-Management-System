using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Domain.Abstract;
using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Domain.Concrete
{
    public class EFTransactionsRepository : ITransactionsRepository
    {
        private readonly EFDbContext context = new EFDbContext();

        public void DeleteTransactions(Transactions transactions)
        {
            context.Entry(transactions).State = System.Data.Entity.EntityState.Deleted;

            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IEnumerable<Transactions> GetAllTransactions()
        {
            { return context.Transactions; }
        }

        public Transactions GetTransactionsById(int Id)
        {
            return context.Transactions.Find(Id);
        }

        public void SaveTransactions(Transactions transactions)
        {
            context.Transactions.Add(transactions);

            context.SaveChanges();
        }

        public IEnumerable<Transactions> SearchTransactions(string searchTerm)
        {
            var Transactions = context.Transactions.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                Transactions = Transactions.Where(a => a.Transaction_Date.ToString().Contains(searchTerm.ToLower()));
            }

            return Transactions.ToList();
        }

        public void UpdateTransactions(Transactions transactions)
        {
            context.Entry(transactions).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();
        }
    }
}
