﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VueWithDotNet.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
