using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_Enums
{
    enum Bonus { bajo = 500, normal = 1000, bueno = 1500, extra = 3000 };
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado Juan = new Empleado(Bonus.extra, 1900.50);

            Console.WriteLine($"El salario del empleado es: {Juan.GetSalario()}");
        }
    }

    struct Empleado
    {
        private double salario;
        private Bonus bonusEmpleado;

        public Empleado(Bonus bonusEmpleado, double salario)
        {
            //bonus = (double)bonusEmpleado;

            this.bonusEmpleado = bonusEmpleado;

            this.salario= salario;
        }

        public double GetSalario() => salario + (double)bonusEmpleado;

    }

    
}
