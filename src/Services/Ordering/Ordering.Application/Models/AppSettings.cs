﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Models
{
    public class AppIdentitySettings
    {
        public EmailSettings emailSettings { get; set; }
        public RabbitMQ rabbitMQ { get; set; }
       
    }

    public class EmailSettings
    {
        //email settings
        public string ApiKey { get; set; }
        public string FromAddress { get; set; }
        public string FromName { get; set; }
    }
    public class RabbitMQ
    {
        public string url { get; set; }
        public string BasketCheckOutQueue { get; set; }
    }
         
}
