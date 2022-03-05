using GitCommits.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitCommits.FakeDb
{
    public class AppDbContext
    {
        public static List<DataOfList> dataOfList = new List<DataOfList>() {
        new DataOfList{ Cotnent="Salam canim",Title="Saba cixiram"},
        };
    }
}
