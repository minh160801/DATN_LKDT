﻿using Microsoft.EntityFrameworkCore;
using shop.Domain.Entities;
using System.Reflection;

namespace shop.Infrastructure.Database.Context;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public AppDbContext()
    {
    }

    public DbSet<ContactEntity> Contact { get; set; }
    public DbSet<AccountEntity> Accounts { get; set; }
    public DbSet<BillEntity> Bill { get; set; }
    public DbSet<BillDetailsEntity> BillDetails { get; set; }
    public DbSet<BlogEntity> Blogs { get; set; }
    public DbSet<CartEntity> Carts { get; set; }
    public DbSet<CartDetailsEntity> CartDetails { get; set; }
    public DbSet<DiscountEntity> Discount { get; set; }
    public DbSet<RankEntity> Ranks { get; set; }
    public DbSet<ReviewEntity> Reviews { get; set; }
    public DbSet<WarrantyEntity> Warranty { get; set; }
    public DbSet<WarrantyCardEntity> WarrantyCards { get; set; }
    public DbSet<SalesEntity> Sales { get; set; }
    public DbSet<SaleDetaildEntity> SaleDetaild { get; set; }
    public DbSet<VirtualItemObjRelationEntity> ItemObjRelationEntities { get; set; }
    
    public DbSet<ApplicationUser> AspNetUsers { get; set; }
    public DbSet<VirtualItemEntity> VirtualItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-4C55HFD4\SQLEXPRESS;Initial Catalog=DuAnTotNghiep_LKDT;Integrated Security=True; TrustServerCertificate = True");
        //cái này là db online
        // optionsBuilder.UseSqlServer("Server = tcp:bazaizaidb.database.windows.net,1433; Initial Catalog = bazaizaidb; Persist Security Info = False; User ID = bazaizai; Password = Trinhanh0311; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<CartEntity>().HasOne(c => c.Accounts).WithOne(p => p.Carts).HasForeignKey<CartEntity>();

        builder.Entity<VirtualItemEntity>().HasKey(p => p.Id);
        //builder.Entity<VW_Phone>().ToView("VW_Phone").HasNoKey();
        //builder.Entity<VW_PhoneDetail>().ToView("VW_PhoneDetail").HasNoKey();
        //builder.Entity<VW_Phone_Group>().ToView("VW_Phone_Group").HasNoKey();
        //builder.Entity<VW_List_By_IdPhone>().ToView("VW_List_By_IdPhone").HasNoKey();
        //builder.Entity<VTop5_PhoneSell>().ToView("VTop5_PhoneSell").HasNoKey();
        //builder.Entity<vOverView>().ToView("vOverView").HasNoKey();
        //builder.Entity<BillGanDay>().ToView("BillGanDay").HasNoKey();
        //builder.Entity<PhoneStatitics>().ToView("PhoneStatitics").HasNoKey();
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
