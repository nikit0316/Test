﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vk
{
    public class GroupData
    {
        public GroupData(string name)
        {
            Name = name;
        }
        
        public string Name { get; set; }
        public string Header { get; set;}

        public string Footer { get; set; }

    }
}