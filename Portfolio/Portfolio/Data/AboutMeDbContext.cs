using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Data
{
    public class AboutMeDbContext : DbContext
    {

    }

    public PortfolioDbContext(DbContext<AboutMeDbContext> options) : base(option)
    {


    }

}
