﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyToGoBq.Classes
{
    class Connection
    {
        public string path;

        public void Connect()
        {

            path = File.ReadAllText(Constants.Database.Path).Trim();
        }
    }
}
