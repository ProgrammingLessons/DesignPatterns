using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    public class Editor : IEditor
    {
        // Authorized department to take the next action
        public IEditor Successor { get; private set; }
        // Next editor is requested in constructor method
        public Editor(IEditor successor)
        {
            Successor = successor;
        }

        // The method by which the document is checked
        public ReviewResult ReviewDocument(Document document)
        {
            // return is defined
            ReviewResult result = new ReviewResult()
            {
                Reviewer = "Editor"
            };
            // Check if there is text in the document
            if (!string.IsNullOrWhiteSpace(document.TextContent))
            {
                if (document.TextContent.Length > 1000)
                {
                    // If it is greater than 1000 characters, send the document to the next authority.
                    return Successor.ReviewDocument(document);
                }
                if (document.TextContent.Length >= 600)
                {
                    // Confirm if greater than 600 characters
                    result.Approved = true;
                }
            }
            return result;
        }
    }
}
