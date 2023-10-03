using HotelProject.EntityLayer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccsessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-J1MPADH\\SABRI;database=apidbb;integrated security=true");
        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<About> abouts { get; set; }
        public DbSet<Booking> bookings { get; set; }
        public DbSet<Guest> guests { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<SendMessage> sendMessages { get; set; }
        public DbSet<MessageCategory> messageCategories { get; set; }
        public DbSet<WorkLocation> workLocations { get; set; }

    
    }
}
