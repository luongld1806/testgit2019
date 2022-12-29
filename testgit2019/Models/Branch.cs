using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testgit2019.Areas.Identity.Data;

namespace testgit2019.Models
{

    public class Branch
    {
        public int Id { get; set; }

        public string Name { get; set; }  
        public string Location { get; set; }

        public int Status { get; set; }
        public virtual List<User> Users { get; set; }
    }
}
