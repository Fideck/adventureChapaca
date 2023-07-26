using api_aventurachapaca.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
namespace api_aventurachapaca.Context
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<UserModel> Usuario { get; set; }
        public DbSet<PagoModel> Pago { get; set; }
        public DbSet<ReservaModel> Reserva { get; set; }
        public DbSet<LugarModel> Lugar { get; set; }    

        public DbSet<IMG_LUGARModel> IMG_LUGAR { get;set; }
        public DbSet<PersonModel> Person { get; set; }
        public DbSet<TourModel> Tour { get; set; }
        public DbSet<Tour_LugarModel> Tour_Lugar { get;set; }
    }
}
