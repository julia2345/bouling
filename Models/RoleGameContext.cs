using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace RoleHSETemp1.Models
{
    public class RoleGameContext :DbContext
    {
        public DbSet<RoleGame> games { get; set; }
    }
}