﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models.Entities
{
    public class ApplicationUserLogin:IdentityUserLogin<Guid>
    {
    }
}
