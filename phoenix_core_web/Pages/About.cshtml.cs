using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.AspNetCore.Mvc.RazorPages;
using phoenix_core_web.Messages;

namespace phoenix_core_web.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            var busControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                var host = cfg.Host(new Uri("rabbitmq://172.18.80.135/"), h =>
                {
                    h.Username("guest");
                    h.Password("guest");
                });

                cfg.ReceiveEndpoint(host, "AddUser1", e =>
                {
                    e.Consumer<AddUserConsumer>();
                });
            });
            busControl.Start();
        }
    }
}
