using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    // Document is defined
    public class Document
    {
        // The document is given an id
        public int Id { get; set; }
        // Content of the document
        public string TextContent { get; set; }
    }
}
