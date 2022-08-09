using InformeBD.Data.entidades;
using InformeBD.entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformeBD.Data
{
    public class BDcontext : DbContext
    {

        public DbSet <Mecanico> Mecanicos { get; set; } 

        public DbSet <Cliente> Clientes { get; set; }

        public DbSet <Vehiculo> Vehiculos { get; set; }

        public DbSet <Secretario> Secretarios { get; set; }


        public BDcontext(DbContextOptions options) : base(options)
        {
        
        }
    }
}
