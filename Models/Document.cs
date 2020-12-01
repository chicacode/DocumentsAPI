using DocumentsAPI.Models.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentsAPI.Models
{
    public class Document
    {
        [Key]
        public int DocumentId { get; set; }

        public DocumentType DocumentType { get; set; }

        [Required]
        [StringLength(100)]
        public string DocumentTitle { get; set; }
        public DateTime CreationDate  { get; set; }

        [StringLength ( 600 )]
        public string DocumentText { get; set; }
        public string DocumentImage { get; set; }
    }
}
