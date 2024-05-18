using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA003_01
{
    internal class Arquitecto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Contrato { get; set; }
        public string Especialidad { get; set; }
        public string Actividad { get; set; }
        public string Afiliacion { get; set; }
        private static decimal porc_est = (decimal)0.16;
        private static decimal porc_rec = (decimal)0.18;
        private static decimal porc_afp = (decimal)0.15;
        private static decimal porc_snp = (decimal)0.08;
        private static int contador = 0;

        public Arquitecto(string codigo, string nombre, string contrato, string especialidad, string actividad, string afiliacion)
        {
            contador++;
            Codigo = codigo;
            Nombre = nombre;
            Contrato = contrato;
            Especialidad = especialidad;
            Actividad = actividad;
            Afiliacion = afiliacion;
        }
        public decimal SueldoBase()
        {
            if (Contrato == "Estable")
            {
                if (Especialidad == "Supervisión de Obras")
                    return 4000;
                else
                    return 6000;
            }    
            else
            {
                if (Especialidad == "Supervisión de Obras")
                    return 2000;
                else
                    return 4500;

            }
        }
        public decimal Bonificacion()
        {
            if (Actividad == "Estructuras")
                return SueldoBase() * porc_est;
            else
                return SueldoBase() * porc_rec;
        }
        public decimal Descuento()
        {
            if (Afiliacion == "AFP")
                return SueldoBase() * porc_afp;
            else
                return SueldoBase() * porc_snp;
        }
        public decimal SueldoBruto()
        {
            return SueldoBase() + Bonificacion();
        }
        public decimal SueldoNeto()
        {
            return SueldoBruto() - Descuento();
        }
        public static int GetContador()
        {
            return contador;
        }
    }
}
