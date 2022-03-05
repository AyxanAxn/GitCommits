using GitCommits.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitCommits.FakeDb
{
    public class AppDbContext
    {
        public static List<DataOfList> DataOfLists { get; set; }

        public AppDbContext()
        {
            DataOfLists.Add(new DataOfList()
            {
                Title = "Salam",
                Cotnent = "Hi"
            });
        }
    }
}