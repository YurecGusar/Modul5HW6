using Modul5HW6Server.ModelsView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modul5HW6Server.Services.Abstractions
{
    public interface ICustomerService
    {
        public void Delete(int id);
        public void Add(CustomerView customer);
        public IEnumerable<CustomerView> GetAll();
    }
}
