﻿using CrecosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CrecosApi.Data
{
    public class CrecosDbContext : DbContext
    {
        public CrecosDbContext(DbContextOptions<CrecosDbContext> options)
            : base(options)
        {            
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalle> DetallesDePedido { get; set; }
        public DbSet<Producto> Productos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Cliente)
                .WithMany(c => c.Pedidos)
                .HasForeignKey(p => p.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PedidoDetalle>()
                .HasKey(pd => pd.Id);

            modelBuilder.Entity<PedidoDetalle>()
                .HasOne(pd => pd.Pedido)
                .WithMany(p => p.DetallesDePedido)
                .HasForeignKey(pd => pd.PedidoId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PedidoDetalle>()
                .HasOne(pd => pd.Producto)
                .WithMany(pr => pr.DetallesDePedido)
                .HasForeignKey(pd => pd.ProductoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
