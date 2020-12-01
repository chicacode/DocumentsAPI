
using Microsoft.EntityFrameworkCore;
using DocumentsAPI.Models;
using System;

namespace DocumentsAPI.Data
{
    public class DocumentsAPIContext : DbContext
    {
        public DocumentsAPIContext ( DbContextOptions<DocumentsAPIContext> options )
            : base ( options )
        {
        }

        public DbSet<Document> Document { get; set; }

        protected override void OnModelCreating ( ModelBuilder modelBuilder )
        {
            base.OnModelCreating ( modelBuilder );
            modelBuilder.Entity<Document> ().HasData (

                  new Document
                  {
                      DocumentId = 1,
                      DocumentType = Models.enums.DocumentType.Simple,
                      DocumentTitle = "Lim Doc",
                      CreationDate = DateTime.Now
                  },
                  new Document
                  {
                      DocumentId = 2,
                      DocumentType = Models.enums.DocumentType.Simple,
                      DocumentTitle = "Simple Doc",
                      CreationDate = DateTime.Now
                  },
                  new Document
                  {
                      DocumentId = 3,
                      DocumentType = Models.enums.DocumentType.Simple,
                      DocumentTitle = "More Simple Doc",
                      CreationDate = DateTime.Now
                  },
                  new Document
                  {
                      DocumentId = 4,
                      DocumentType = Models.enums.DocumentType.Advanced,
                      DocumentTitle = "Fake Doc",
                      CreationDate = DateTime.Now,
                      DocumentText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book",
                      DocumentImage = "https://images.unsplash.com/photo-1606694582797-0324662ab736?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=726&q=80"
                  },
                  new Document
                  {
                      DocumentId = 5,
                      DocumentType = Models.enums.DocumentType.Advanced,
                      DocumentTitle = "Foko Doc",
                      CreationDate = DateTime.Now,
                      DocumentText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book",
                      DocumentImage = "https://images.unsplash.com/photo-1457694587812-e8bf29a43845?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=751&q=80"

                  },
                  new Document
                  {
                      DocumentId = 6,
                      DocumentType = Models.enums.DocumentType.Advanced,
                      DocumentTitle = "Foka Doc",
                      CreationDate = DateTime.Now,
                      DocumentText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book",
                      DocumentImage = "https://images.unsplash.com/photo-1603796846097-bee99e4a601f?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=667&q=80"
                  },
                  new Document
                  {
                      DocumentId = 7,
                      DocumentType = Models.enums.DocumentType.Custom,
                      DocumentTitle = "New Custom Doc",
                      CreationDate = DateTime.Now,
                      DocumentText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book"
                  },
                  new Document
                  {
                      DocumentId = 8,
                      DocumentType = Models.enums.DocumentType.Custom,
                      DocumentTitle = "Better Custom Doc",
                      CreationDate = DateTime.Now,
                      DocumentText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book"
                  },
                  new Document
                  {
                      DocumentId = 9,
                      DocumentType = Models.enums.DocumentType.Custom,
                      DocumentTitle = "The best Custom Doc",
                      CreationDate = DateTime.Now,
                      DocumentText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book"
                  }
                );
        }
    }
}
