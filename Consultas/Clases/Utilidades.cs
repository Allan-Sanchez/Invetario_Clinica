using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas.Clases
{
    class Utilidades
    {
        private static decimal numero_decimal = 0;
        private static decimal numero_Cero = 0;
        private static string error;

        public static string Error
        {
            get { return Utilidades.error; }
            set { Utilidades.error = value; }
        }

        public decimal Numero_decimal
        {
            get { return numero_decimal; }
            set { numero_decimal = value; }
        }

        public static bool ValidarDecimal(string numero) 
        {
            try
            {
                numero_decimal = Convert.ToDecimal(numero);
                error = "";
                return true;
            }
            catch (Exception ex)
            {

                error = ex.Message;
                return false;
            }
        
        }

        public static bool Numero_Mayor_Cero(string numero) 
        {
            try
            {
                numero_Cero = Convert.ToDecimal(numero);
                if (numero_Cero<0)
                {
                    error = "";
                    return true;
                }
                error="";
                return true;
            }
            catch (Exception ex1)
            {

                error = ex1.Message;
                return false;
            }
        }

    }
}
