﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPEcommerce.Orders.Events
{
    public class NewOrderCreatedEvent
    {
        public string CustomerEmail { get; set; }
        public string Message { get; set; }
    }
}
