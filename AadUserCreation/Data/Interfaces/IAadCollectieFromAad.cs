﻿using AadUserCreation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AadUserCreation.Data.Interfaces
{
    public interface IAadCollectieFromAad
    {
        Task<GroupListDetails> GetGroupListDetails();
    }
}
