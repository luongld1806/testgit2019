using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testgit2019.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name {get; set;}
        public string Image {get; set;}

        public virtual List<Food> Foods { get; set; }
    }
}
