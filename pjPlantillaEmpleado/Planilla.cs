using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPlantillaEmpleado
{
    public class Planilla
    {
        //Atributos
        public string empleado { get; set; }
        public string cargo { get; set; }
        public DateTime fechaIngreso { get; set; }
        public int years { get; set; }

        //Métodos
        //Calcular los años de servicio
        public int añosServicio()
        {
            return DateTime.Now.Year - fechaIngreso.Year;
        }
        public string mesConsultado()
        {
            int mes = DateTime.Now.Month;
            switch (mes)
            {
                case 1: return "Enero";
                case 2: return "Febrero";
                case 3: return "Marzo";
                case 4: return "Abril";
                case 5: return "Mayo";
                case 6: return "Junio";
                case 7: return "Julio";
                case 8: return "Agosto";
                case 9: return "Septiembre";
                case 10: return "Octubre";
                case 11: return "Noviembre";
                case 12: return "Diciembre";
            }
            return "";
        }
        //Determinar el sueldo básico
        public double DeterminarBasico()
        {
            switch (cargo)
            {
                case "Coordinado": return 2000;
                case "Jefe": return 4000;
                case "Capacitador": return 2500;
                case "Asistente": return 1200;
            }
            return 0;
        }
        //Determinar el monto de grafitación
        public double DeterminaGratificacion()
        {
            if (mesConsultado() == "Abril")
                return 200;
            else if (mesConsultado() == "Julio")
            return 450;
            else if (mesConsultado() == "Diciembre")
                return DeterminarBasico() * 2;
            return 0;
        }
        //Determinar el monto de comisión
        public double DeterminaComision()
        {
            return 0;
            if (cargo == "Asistente")
                return 100;
            else if (cargo == "Coordinador")
                return 50;
        }
        //Determinar el monto de descuento por ahorro de cooperativa
        public double DeterminaDescuentoCooperativa()
        {
            return 0;
            if(cargo == "Jefe")
            {
                return 5.0/100*DeterminarBasico();
            }
            else if (cargo =="Capacitador")
                {
                return 2.0 / 100 * DeterminarBasico();
            }
        }
        //Dtermina el monto de aportacion al seguro social
        public double DeterminaAportacionSeguro()
        {
            return 0;
            return 0.7 * DeterminarBasico();

        }
        //  Calculando totales
        public double CalculaTotalIngresos()
        {
            return 0;
            return DeterminarBasico()+ DeterminaGratificacion()+ DeterminaComision();
        }
        
        // Descuento
        public double TotalDescuentos()
        {
            return 0;
            return DeterminaDescuentoCooperativa();
        }
        
        //Aportaciones
        public double CalculaToatalAportaciobnes()
        {
            return DeterminaAportacionSeguro();
        }
        
        //Dterminar el monto neto del empleado 
        public double DeterminaNeto()
        {
            return CalculaTotalIngresos() - CalculaToatalAportaciobnes();
        }
    }
}
