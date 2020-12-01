using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DocumentsAPI.Models;

namespace DocumentsAPI.Data
{
    public class DocumentsAPIContext : DbContext
    {
        public DocumentsAPIContext (DbContextOptions<DocumentsAPIContext> options)
            : base(options)
        {
        }

        public DbSet<DocumentsAPI.Models.Document> Document { get; set; }
    }
}
