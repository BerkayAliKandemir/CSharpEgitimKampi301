using CSharpEgitimKampi301.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Context
{
    public class KampContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        // veri tabanına yansıyacak butun tablolar kampcontext ıcıne yazılmalı
        //category -csharpta kullanılacak sınıf ısmı
        // categoris- sql e yansıyacak tablo  - yalın class cogul tablo
        public DbSet<Product> Products { get; set; }
        // bunların hepsi public olmalı unutma classlar yani
        //context icine veritabanı bilgisi ve veritabanı baglantı adresi yazacam
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }


    }
}
