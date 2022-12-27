using ASpNetCore.MVC.Models;
using System.Collections.Generic;

namespace ASpNetCore.MVC.BusinessObject
{
    public interface ITechnologyRepository
    {
        List<Technology> GetList();
        Technology GetById(int Id);
    }
}
