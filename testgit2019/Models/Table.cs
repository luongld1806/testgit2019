﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace testgit2019.Models
{
    public class Table
    {
        public int Id { get; set; }
        public string Name {get;set;}
        public TableType Type {get;set;}
        [ForeignKey("Branch")]
        public int BranchId {get;set;}
        public int NumberOfGuest {get;set;}
        public int Status {get;set;}

        public Branch Branch {get;set;}
    }
}
