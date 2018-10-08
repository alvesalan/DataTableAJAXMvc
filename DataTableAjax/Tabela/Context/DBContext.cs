using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Tabela.Models;

namespace Tabela.Context
{
    public class DBContext : DbContext
    {
        public DbSet<Usuarios> usuarios { get; set; }
    }
}