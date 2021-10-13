using Modul5HW6Server.ModelsView;
using Modul5HW6Server.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modul5HW6Server.Services
{
    public class CustomerService : ICustomerService
    {
        private List<CustomerView> _customers = new List<CustomerView>()
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
        };

        public IEnumerable<CustomerView> GetAll()
        {
            return _customers;
        }

        public void Add(CustomerView customer)
        {
            _customers.Add(customer);
        }

        public void Delete(int id)
        {
            _customers.Remove(_customers.FirstOrDefault(x => x.Id == id));
        }
    }
}
