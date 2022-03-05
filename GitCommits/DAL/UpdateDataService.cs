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
        public void updateData(DataOfList data)
        {

            var datas = AppDbContext.dataOfList.FirstOrDefault(d => d.Id == data.Id);
            if (datas != null)
            {
                data.Title = datas.Title;
                data.Cotnent = datas.Cotnent;
            }
        }
    }
}