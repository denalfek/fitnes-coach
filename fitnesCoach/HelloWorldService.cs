using FitnesCoach.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnesCoach.Api
{
    public class HelloWorldService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello World!";
        }
    }
}
