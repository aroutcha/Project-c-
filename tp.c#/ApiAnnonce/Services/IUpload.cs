﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAnnonce.Services
{
    public interface IUpload
    {
        string Upload(IFormFile image);
    }
}
