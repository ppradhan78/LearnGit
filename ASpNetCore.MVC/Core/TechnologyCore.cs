using ASpNetCore.MVC.BusinessObject;
using ASpNetCore.MVC.Models;
using System;
using System.Collections.Generic;

namespace ASpNetCore.MVC.Core
{
    public class TechnologyCore : ITechnologyCore
    {
        private readonly ITechnologyRepository _technology;
        public TechnologyCore(ITechnologyRepository technology)
        {
            _technology= technology;
        }
        public Technology GetById(int Id)
        {
            if (Id<=0)
            {
                throw new Exception("Invalid Id");   
            }
            return _technology.GetById(Id);
        }

        public List<Technology> GetList()
        {
           return _technology.GetList();
        }
    }
}
