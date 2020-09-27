using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using Prestamos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Prestamos.DAL
{
    public class Contexto : DbContext
    {
   public DbSet <Personas> Personas { get; set; }
   public DbSet<Prestamo> Prestamo { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
       optionsBuilder.UseSqlite(@"Data Source= DATA\Prestamos.db");
   }
    }
}