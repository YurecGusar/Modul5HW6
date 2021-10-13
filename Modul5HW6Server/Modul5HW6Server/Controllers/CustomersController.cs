using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Modul5HW6Server.ModelsView;
using Modul5HW6Server.Services;
using Modul5HW6Server.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modul5HW6Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private ICustomerService _cstmrSrvc;

        public CustomersController(ICustomerService customerService)
        {
            _cstmrSrvc = customerService;
        }

        [HttpGet]
        public IEnumerable<CustomerView> Get()
        {
            return _cstmrSrvc.GetAll();
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            _cstmrSrvc.Delete(id);
        }
    }
}
