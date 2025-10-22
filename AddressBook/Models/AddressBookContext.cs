using Microsoft.EntityFrameworkCore;

namespace AddressBook.Models;

public class AddressBookContext : DbContext
{
    public AddressBookContext(DbContextOptions<AddressBookContext>options)
        : base(options)
    {
    }
    public DbSet<AddressBookItem> AddressBookItems { get; set; } = null;
}
