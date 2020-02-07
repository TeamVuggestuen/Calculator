﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCal1
{
    public interface ICalculater
    {
        double Add(double a, double b);

        double Subtract(double a, double b);

        double Multiply(double a, double b);

        double Power(double a, double b);

        double Divide(double a, double b);

        void Clear();

    }
}
