using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustoFuncionarioApp.Models;

namespace CustoFuncionarioApp.Data
{
    public class CustoFuncionarioAppContext : DbContext
    {
        public CustoFuncionarioAppContext (DbContextOptions<CustoFuncionarioAppContext> options)
            : base(options)
        {
        }

        public DbSet<CustoFuncionarioApp.Models.Funcionario> Funcionario { get; set; } = default!;
    }
}
