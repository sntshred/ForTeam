﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCareBusinessServices
{
    public interface IUserServices
    {
        int Authenticate(string userName, string password);
    }
}
