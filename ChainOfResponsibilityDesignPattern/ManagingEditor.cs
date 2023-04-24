using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    public class ManagingEditor : IEditor
    {
        // last unit to approve
        public ReviewResult ReviewDocument(Document document)
        {
            ReviewResult result = new ReviewResult()
            {
                Reviewer = "Managing Editor"
            };
            // Checking whether the document has content is checked,
            // if there is content and it is more than 2000 characters, the document is approved.
            result.Approved = !string.IsNullOrWhiteSpace(document.TextContent) && document.TextContent.Length > 2000;
            return result;
        }
    }
}
