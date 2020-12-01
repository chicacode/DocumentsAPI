using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentsAPI.Models
{
    public class Document
    {
        public int DocumentId { get; set; }
        public string DocumentTitle { get; set; }
        public DateTime CreationDate  { get; set; }
        public string DocumentText { get; set; }
        public string DocumentImage { get; set; }
    }
}
