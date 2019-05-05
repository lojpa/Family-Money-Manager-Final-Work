using FamilyMoneyManagerApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Context
{
    public class FamilyMoneyManagerContext : DbContext
    {
        public FamilyMoneyManagerContext(DbContextOptions<FamilyMoneyManagerContext> options) : base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ExpenseIncome> ExpenseIncomes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemCart> ItemCarts { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ExpenseIncome>()
                .HasOne(a => a.Account)
                .WithMany(ei => ei.ExpenseIncomes)
                .HasForeignKey(f => f.AccountId);

            modelBuilder.Entity<ExpenseIncome>()
               .HasOne(ei => ei.Category)
               .WithMany(c => c.ExpenseIncomes)
               .HasForeignKey(cat => cat.CategoryId);


            modelBuilder.Entity<ItemCart>()
               .HasOne(ei => ei.ShoppingCart)
               .WithMany(c => c.Items)
               .HasForeignKey(cat => cat.ShoppingCartId);

            modelBuilder.Entity<ItemCart>()
               .HasOne(ei => ei.Item)
               .WithMany(c => c.ItemCarts)
               .HasForeignKey(cat => cat.ItemId);

        }
    }
}
