using System;
using System.Collections.Generic;

namespace ChainOfResponsibilityDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List to hold documents
            List<Document> documents = new List<Document>()
                {
                    new Document() { Id = 1, TextContent = new string('*', 500)},
                    new Document() { Id = 2, TextContent = new string('*', 850)},
                    new Document() { Id = 3, TextContent = new string('*', 1500)},
                    new Document() { Id = 4, TextContent = new string('*', 2500) }
                };

            // Hierarchy of the editors and the editor are defined.
            IEditor editor = new Editor(new ExecutiveEditor(new ManagingEditor()));
            documents.ForEach(x =>
            {
                // each document is sent sequentially to the editor
                var result = editor.ReviewDocument(x);
                Console.WriteLine(result.Approved ? "Document {0} approved by {1}"
                    : "Document {0} rejected by {1}",
                                  x.Id, result.Reviewer);
            });
        }
    }
}
