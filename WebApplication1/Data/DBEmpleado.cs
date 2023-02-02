using Microsoft.EntityFrameworkCore;
using SistemaWebEmpleado.Models;
using System.Collections.Generic;

namespace SistemaWebEmpleado.Data
{
    public class DBEmpleado : DbContext
    {
        public DBEmpleado(DbContextOptions<DBEmpleado> options) : base(options) { }


        public DbSet<Empleado> Empleados { get; set; }

    }
}
