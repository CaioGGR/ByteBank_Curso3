using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario //Diretor é um funcionário
    {

        public override double GetBonificacao()
        {
            return salario + base.GetBonificacao(); // o base especifica que estamos falando do getbonificacao da class funcionario
        }
    }
}
