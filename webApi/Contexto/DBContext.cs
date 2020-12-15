using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using webApi.Models;

namespace Contexto {

    public class ContextoDB: DbContext {
        private string connectionStrings = "";

       public DbSet<ButtonsMenuModel> TabelaButtonsMenu {get; set;}
       public DbSet<LoginModel> TabelaUsuarios {get; set;}

    public ContextoDB(IConfiguration configuration){
        //this.connectionStrings = configuration.GetSection("ConnectionStrings").Value;
        this.Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        //Usar chumbado por momento
        optionsBuilder.UseSqlServer(@"Data Source=SPDECPD23\SQLEXPRESS;Initial Catalog=Portifolio;Integrated Security=True;Connect Timeout=30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }

   protected override void OnModelCreating(ModelBuilder builder){
        GenerateData PrepareData = new GenerateData(builder);
    }
    



        

    }
     
}