﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyContainer.UnitTests.RegisteredClasses
{
    public class AlternateLogger : ILogger
    {
        public void Log(string message)
        {
        }
    }
}
