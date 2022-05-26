﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {

        public string Nome { get; set; }
        public string CPF { get; set; }
        public double salario { get; set; }

        public virtual double GetBonificacao()
        {
            return salario * 0.10;
        }
    }
}