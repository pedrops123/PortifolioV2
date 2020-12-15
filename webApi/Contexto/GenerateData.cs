using System;
using Microsoft.EntityFrameworkCore;
using webApi.Models;

public class GenerateData {
       /// <summary>
       /// Popula todas as tabelas com os dados default
       /// </summary>
    public GenerateData(ModelBuilder modelBuilder){
         populaTabelaBotoes(modelBuilder);
         populaUsuarios(modelBuilder);
    }

    private void populaTabelaBotoes(ModelBuilder builder){
          builder.Entity<ButtonsMenuModel>()
            .HasData(
                new ButtonsMenuModel(){
                    Id = 1,
                    description = "Inicio",
                    href = "inicio",
                    color = null
                },
                 new ButtonsMenuModel(){
                    Id = 2,
                    description = "Meus Trabalhos",
                    href = "work",
                    color = null
                },
                 new ButtonsMenuModel(){
                    Id = 3,
                    description = "Contato",
                    href = "contact",
                    color = null
                }
            );

    }

    private void populaUsuarios(ModelBuilder builder){
        builder.Entity<LoginModel>().HasData(
            new LoginModel(){
                    id = 1,
                    login = "pedro.furlan",
                    senha = "123456",
                    roles = "Adm" 
                }
            );
    }
}