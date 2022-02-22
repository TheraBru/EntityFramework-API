using Microsoft.EntityFrameworkCore;
using moment33.Models;

namespace moment33.Data;
// DbContext class
public class SongContext : DbContext{
    public SongContext(DbContextOptions<SongContext> options) : base(options){

    }

    public DbSet<Song>? Songs { get; set; }
}