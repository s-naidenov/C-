﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesCovarianceAndContravariance
{
    internal interface IBank<out T>
    {
        T CreateAccount(int sum);
    }

}
