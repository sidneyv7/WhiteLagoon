﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Application.Services.Interface
{
    public interface IVillaService
    {
        IEnumerable<Villa> GetAllVillas();
        void CreateVilla(Villa villa);
        void UpdateVilla(Villa villa);
        Villa GetVillaById(int villaId);
        bool DeleteVilla(int villaId);

    }
}