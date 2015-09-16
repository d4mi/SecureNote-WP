using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.Model
{
    public class Document
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public DateTime Created { get; set; }

        public string CreatedAsString
        {
            get
            {
                return Created.ToString();
            }
        }

        public Document()
        {
            Name = String.Empty;
            Description = String.Empty;
            ImagePath = String.Empty;
            Created = DateTime.Now;
        }
    }
}
