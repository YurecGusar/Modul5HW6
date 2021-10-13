using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Modul5HW6Server.ModelsView;
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
        [HttpGet]
        public IEnumerable<CustomerView> Get()
        {
            return new List<CustomerView>()
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
                    FirstName = "Name",
                    LastName = "Second"
                },

                new CustomerView()
                {
                    Id = 3,
                    FirstName = "Name",
                    LastName = "Second"
                },

                new CustomerView()
                {
                    Id = 4,
                    FirstName = "Name",
                    LastName = "Second"
                },

                new CustomerView()
                {
                    Id = 5,
                    FirstName = "Name",
                    LastName = "Second"
                },

                new CustomerView()
                {
                    Id = 6,
                    FirstName = "Name",
                    LastName = "Second"
                },
            };
        }
    }
}
