using GitCommits.FakeDb;
using GitCommits.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitCommits.DAL
{
    public class UpdateDataService
    {
        public static void UpdateData(DataOfList data)
        {
            var datas = AppDbContext.DataOfLists.FirstOrDefault(d => d.Id == data.Id);
            if (datas != null)
            {
                datas.Title = data.Title;
                datas.Cotnent = data.Cotnent;
            }
        }
    }
}