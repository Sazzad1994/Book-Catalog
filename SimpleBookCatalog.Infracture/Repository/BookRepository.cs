
using Microsoft.EntityFrameworkCore;
using SimpleBookCatalog.Application.Repository;
using SimpleBookCatalog.Domain.Entities;
using SimpleBookCatalog.Infracture.Context;

namespace SimpleBookCatalog.Infracture.Repository;

public class BookRepository: IBookRepository
{
    private readonly SimpleBookCatDbContext _dbContext;
    public BookRepository(IDbContextFactory<SimpleBookCatDbContext>factory)
    {
        _dbContext = factory.CreateDbContext();
    }

    public async Task AddSync(Book book)
    {
        _dbContext.Books.Add(book);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteByIdAsync(int id)
    {
      var book=  await GetByIdAsync(id);
        if (book != null) { 
           _dbContext.Books.Remove(book);
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task<List<Book>> GetAllAsync()
    {
       var books=await _dbContext.Books.ToListAsync();
        return books;
    }

    public async Task<Book?> GetByIdAsync(int id)
    {
        var book = await _dbContext.Books.FirstOrDefaultAsync(e => e.Id == id);
        return book;
    }

    public async Task UpdateAsync(Book book)
    {
       _dbContext.Entry(book).State=EntityState.Modified;
        await _dbContext.SaveChangesAsync();
    }
}
