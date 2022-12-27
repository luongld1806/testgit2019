using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testgit2019.Areas.Identity.Data;

namespace testgit2019.Models
{
    public class BranchManager
    {
        
        public int UserId { get; set; }
        public int BranchId { get; set; }
        public User User { get; set; }
        public Branch Branch { get; set; }
    }
}
