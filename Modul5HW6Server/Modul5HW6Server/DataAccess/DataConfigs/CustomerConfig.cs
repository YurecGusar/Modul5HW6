using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul5HW6Server.ModelsView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modul5HW6Server.DataAccess.DataConfigs
{
    public class CustomerConfig : IEntityTypeConfiguration<CustomerView>
    {
        public void Configure(EntityTypeBuilder<CustomerView> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder
                .Property(x => x.FirstName)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(x => x.LastName)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();

            builder
                .HasData(new List<CustomerView>()
                {
                    new CustomerView()
                    {
                    Id = 1,
                    FirstName = "Yurii",
                    LastName = "Leonov"
                    },

                    new CustomerView()
                    {
                    Id = 2,
                    FirstName = "Andry",
                    LastName = "Sergeev"
                    },

                    new CustomerView()
                    {
                    Id = 3,
                    FirstName = "Dima",
                    LastName = "Nazarov"
                    },

                    new CustomerView()
                    {
                    Id = 4,
                    FirstName = "Alegzander",
                    LastName = "Shpic"
                    },

                    new CustomerView()
                    {
                    Id = 5,
                    FirstName = "Sergey",
                    LastName = "Polchaninov"
                    },

                    new CustomerView()
                    {
                    Id = 6,
                    FirstName = "Stepan",
                    LastName = "Bandera"
                    }
                });
        }
    }
}
