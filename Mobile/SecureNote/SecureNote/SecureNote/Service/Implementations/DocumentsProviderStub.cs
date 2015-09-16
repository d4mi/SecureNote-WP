using SecureNote.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.Service.Implementations
{
    class DocumentsProviderStub : IDocumentsProvider
    {
        public IEnumerable<Document> GetDocuments()
        {
            List<Document> documents = new List<Document>();
            documents.Add(new Document() { Name = "Doc1", Description = "Simple text", ImagePath = "Images/wordIcon.png" });
            documents.Add(new Document() { Name = "Doc2", Description = "Simple text", ImagePath = "Images/wordIcon.png" });
            documents.Add(new Document() { Name = "Doc3", Description = "Simple text", ImagePath = "Images/wordIcon.png" });
            documents.Add(new Document() { Name = "Doc4", Description = "Simple text", ImagePath = "Images/wordIcon.png" });
            documents.Add(new Document() { Name = "Doc4", Description = "Simple text", ImagePath = "Images/wordIcon.png" });
            documents.Add(new Document() { Name = "Doc5", Description = "Simple text", ImagePath = "Images/wordIcon.png" });
            documents.Add(new Document() { Name = "Doc6", Description = "Simple text", ImagePath = "Images/wordIcon.png" });
            documents.Add(new Document() { Name = "Doc7", Description = "Simple text", ImagePath = "Images/wordIcon.png" });
            documents.Add(new Document() { Name = "Doc8", Description = "Simple text", ImagePath = "Images/wordIcon.png" });
            documents.Add(new Document() { Name = "Doc9", Description = "Simple text", ImagePath = "Images/wordIcon.png" });
            documents.Add(new Document() { Name = "Doc0", Description = "Simple text", ImagePath = "Images/wordIcon.png" });

            return documents;
        }
    }
}
