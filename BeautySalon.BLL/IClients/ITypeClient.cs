﻿using BeautySalon.BLL.Models.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.BLL.IClient
{
    public interface ITypeClient
    {
        public List<AllServiceTypeOutputModel> GetAllServiceTypes();
    }
}
