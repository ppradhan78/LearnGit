using ASpNetCore.MVC.Models;
using System.Collections.Generic;

namespace ASpNetCore.MVC.BusinessObject
{
    public class TechnologyRepository : ITechnologyRepository
    {
        private List<Technology> Technologys = new List<Technology>();
        public TechnologyRepository()
        {
            Technologys.Add(new Technology {Id=1,Name="C#" });
            Technologys.Add(new Technology { Id = 1, Name = "C#" });
            Technologys.Add(new Technology { Id = 2, Name = "Python" });
            Technologys.Add(new Technology { Id = 3, Name = "JavaScript" });
            Technologys.Add(new Technology { Id = 4, Name = "Azure" });
            Technologys.Add(new Technology { Id = 5, Name = "SqlServer" });

        }
        public Technology GetById(int Id)
        {
            return Technologys.Find(t => t.Id == Id);
        }

        public List<Technology> GetList()
        {
            return Technologys;
        }
    }
}
