using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TAREA003_02
{
    internal class Jefe
    {
        public string Codigo { get; set; }
        public string DNI { get; set; }
        public string Cargo { get; set; }
        public string Area { get; set; }
        public int Años { get; set; }
        private static decimal porc_7 = (decimal)0.05;
        private static decimal porc_8 = (decimal)0.04;

        private static int contador = 0;

        public Jefe(string codigo, string dni, string cargo, string area, int años)
        {
            contador++;
            Codigo = codigo;
            DNI = dni;
            Cargo = cargo;
            Area = area;
            Años = años;
        }
        public decimal SueldoBase()
        {
            if (Cargo == "Gerente")
            {
                if (Area == "Contabilidad")
                    return 6000;
                else
                    return 7000;
            }
            else
            {
                if (Area == "Contabilidad")
                    return 5000;
                else
                    return 6000;

            }
        }
        public decimal Bonificacion()
        {
            if (Cargo == "Gerente")
                return 700;
            else
                return 400;
        }
        public decimal Porcentaje()
        {
            if (Años < 8)
                return SueldoBase() * porc_7;
            else
                return SueldoBase() * porc_8;
        }
        public decimal SueldoFinal()
        {
            return SueldoBase() + Bonificacion() + Porcentaje();
        }
        public static int GetContador()
        {
            return contador;
        }
    }
}

