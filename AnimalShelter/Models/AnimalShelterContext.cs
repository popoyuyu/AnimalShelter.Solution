using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class ToDoListContext : DbContext
  {
    public DbSet<Item> Items { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}