using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ChatHistoryAPI.Models
{
    public class ChatAppContext : DbContext
    {
        public ChatAppContext(DbContextOptions<ChatAppContext> options) : base(options) { }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}