using GitCommits.FakeDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitCommits.DAL
{
    public static class RemoveDataServices
    {
        public static void RemoveData(int Id)
        {
            try
            {
                AppDbContext.DataOfLists.Remove(AppDbContext.DataOfLists.FirstOrDefault(x => x.Id == Id));
            }
            catch(Exception ex)
            {
                 

            }
        }
    }
}
