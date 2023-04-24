using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ChainOfResponsibilityDesignPattern
{
    public class ExecutiveEditor : IEditor
    {
        // Authorized department to take the next action
        public IEditor Successor { get; private set; }
        // Next editor is requested in constructor method
        public ExecutiveEditor(IEditor successor)
        {
            Successor = successor;
        }

        // The method by which the document is checked
        public ReviewResult ReviewDocument(Document document)
        {
            // return is defined
            ReviewResult result = new ReviewResult()
            {
                Reviewer = "Executive Editor"
            };
            // Check if there is text in the document
            if (!string.IsNullOrWhiteSpace(document.TextContent))
            {
                // If it is greater than 2000 characters, send the document to the next authority.
                if (document.TextContent.Length > 2000)
                {
                    return Successor.ReviewDocument(document);
                }
                // If the content of the document is less than 1500 characters, reject it.
                if (document.TextContent.Length <= 1500)
                {
                    result.Approved = false;
                }
                // Confirm if the content of the document is more than 1500 characters.
                if (document.TextContent.Length > 1500)
                {
                    result.Approved = true;
                }
            }
            return result;
        }
    }
}
