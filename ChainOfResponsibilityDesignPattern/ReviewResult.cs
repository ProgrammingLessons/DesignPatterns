using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    // class to return on approval or rejection of the post
    public class ReviewResult
    {
        // Approved or rejected
        public bool Approved { get; set; }
        // the name of the person performing the transaction
        public string Reviewer { get; set; }
    }
}
