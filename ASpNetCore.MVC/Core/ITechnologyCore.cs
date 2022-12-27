using ASpNetCore.MVC.Models;
using System.Collections.Generic;

namespace ASpNetCore.MVC.Core
{
    public interface ITechnologyCore
    {
        List<Technology> GetList();
        Technology GetById(int Id);
    }
}
