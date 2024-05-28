using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Domain.Abstract
{
    public interface ITransactionsRepository
    {
        IEnumerable<Transactions> GetAllTransactions();
        IEnumerable<Transactions> SearchTransactions(string searchTerm);
        void SaveTransactions(Transactions transactions);
        void UpdateTransactions(Transactions transactions);
        void DeleteTransactions(Transactions transactions);
        Transactions GetTransactionsById(int Id);
        void Dispose();
    }
}
