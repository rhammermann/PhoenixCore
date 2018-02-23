using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using phoenix_core_web.Messages;

namespace phoenix_core_web.Pages
{
    public class IndexModel : PageModel {
        IBus _bus;

        public IndexModel(IBus bus) {
            _bus = bus;
        }

        public async void OnGet() {
            var addUserEndpoint = _bus.GetSendEndpoint(new Uri("rabbitmq://172.22.149.120/AddUser1"));

            //await addUserEndpoint.Start<AddUser>(new
            //{
            //    FirstName = "Simon",
            //    LastName = "Tibbs",
            //    EmailAddress = "stimms@gmail.com",
            //    Password = "A wicked secret password"
            //});
        }
    }
}
