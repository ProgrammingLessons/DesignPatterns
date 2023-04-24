using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    // Interface where editor types will be created
    public interface IEditor
    {
        ReviewResult ReviewDocument(Document document);
    }
}
