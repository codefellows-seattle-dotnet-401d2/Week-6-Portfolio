using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio
{
    interface IAboutMe 
    {
        Task DeleteAsync(int ID);

        AboutMe Find(int id);

        Task<AboutMe> FindAsynch();

        IQueryable<AboutMe> GetAll(int? count = null, int? page = null);




    }
}
