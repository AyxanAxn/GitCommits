using GitCommits.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitCommits.FakeDb
{
    public static class AppDbContext
    {
        public static List<DataOfList> DataOfLists { get; set; } = new List<DataOfList>();
    }
}