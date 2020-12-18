using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using webApi.Models;

public class GenerateData {
       /// <summary>
       /// Popula todas as tabelas com os dados default
       /// </summary>
    public GenerateData(ModelBuilder modelBuilder){
         populaTabelaBotoes(modelBuilder);
         populaTabelaAcesso(modelBuilder);
         populaUsuarios(modelBuilder);
    }

    private void populaTabelaAcesso(ModelBuilder builder){
       
        builder.Entity<UsuarioAcesso>().HasData(
             new UsuarioAcesso(){
                Id = 1,
                DescricaoAcesso = "Adm"
            },
            new UsuarioAcesso(){
                Id = 2,
                DescricaoAcesso = "User"
            });
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
        builder.Entity<UsuariosModel>().HasData(
            new UsuariosModel(){
                    Id = 1,
                    Login = "pedro.furlan",
                    Senha = "123456",
                    UsuarioAcessoId = 1
                   // UsuarioAcessoId = 1
                }
            );
    }
}