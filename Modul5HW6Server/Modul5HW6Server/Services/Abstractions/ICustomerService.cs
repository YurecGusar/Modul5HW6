using Modul5HW6Server.ModelsView;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Modul5HW6Server.Services.Abstractions
{
    public interface ICustomerService
    {
        public Task DeleteByAsync(int id);
        public Task<IEnumerable<CustomerView>> GetAllAsync();
    }
}
