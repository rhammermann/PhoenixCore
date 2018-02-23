using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MassTransit;

namespace phoenix_core_web.Messages
{
    public class AddUserConsumer : IConsumer<AddUser>
    {
        public Task Consume(ConsumeContext<AddUser> context)
        {
            Console.WriteLine($"Adding user {context.Message.FirstName} {context.Message.LastName}");
            return Task.CompletedTask;
        }
    }
}
