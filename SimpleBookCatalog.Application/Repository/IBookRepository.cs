using SimpleBookCatalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBookCatalog.Application.Repository
{
    public interface IBookRepository
    {
        Task AddSync(Book book);
        Task<List<Book>> GetAllAsync();
       
        Task UpdateAsync(Book book);

        Task DeleteByIdAsync(int id);

        Task<Book?> GetByIdAsync(int id);
    }
}
