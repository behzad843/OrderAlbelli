﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Model.Models
{
    public class OrderListCreateRequest
    {
        public List<OrderCreateRequest> orderRequest { get; set; }
    }
}
