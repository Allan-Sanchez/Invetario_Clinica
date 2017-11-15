using Consultas.ConsultaMedicaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas.Clases
{
    class Consulta_Paciente
    {

        private static ConsultasTableAdapter adaptador = new ConsultasTableAdapter();

        public static void InsertConsulta(string Medico, string Nombres, string Consulta, decimal Costo, decimal Otros_Costos, DateTime fecha_Consulta, string Observacones)
        {

            adaptador.InsertConsulta(Medico, Nombres, Consulta, Costo, Otros_Costos, fecha_Consulta, Observacones);
        }

        public static void UpdateConsulta(string Medico, string Nombres, string Consulta, decimal Costo, decimal Otros_Costos, DateTime fecha_Consulta, string Observacones, int id_Cosulta)
        {

            adaptador.UpdateConsulta(Medico, Nombres, Consulta, Costo, Otros_Costos, fecha_Consulta, Observacones, id_Cosulta);
        }

        public static void DeleteConsulta(int id_Cosulta)
        {
            adaptador.DeleteConsulta(id_Cosulta);
        }

        public static void DeleteTodas_las_Consultas()
        {
            adaptador.DeleteTodas_las_Consultas();
        }

        public static decimal Suma_Consultas()
        {
            return (decimal)adaptador.Suma_Consultas();
        }

        public static decimal Suma_Otros_Costos()
        {
            return (decimal)adaptador.Suma_Otros_Costos();
        }

        public static decimal Suma_Total()
        {
            return (decimal)adaptador.Suma_Total();
        }

        public static decimal SUMA_CON_IVA()
        {
            return (decimal)adaptador.SUMA_CON_IVA();
        }

    }
}
