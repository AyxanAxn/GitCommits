using GitCommits.FakeDb;
using GitCommits.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitCommits.DAL
{
    public static class AddDataService
    {
        public static int Id { get; set; } = 1;
        public static void AddData(string title, string content)
        {
            var data = new DataOfList()
            {
                Id = Id,
                Title = title,
                Cotnent = content
            };
            Id++;
            AppDbContext.DataOfLists.Add(data);
        }
    }
}
