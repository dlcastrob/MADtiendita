using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace AVANCE2
{
    //jeje
    //SESESESEROOOOOOOOOOOOOOOOOOOOOOOOO
    //AWE

    public static class FUNCIONES
    {

        public static int GetLastDayOfMonth(string fecha)
        {
            int diasMes = 0;
            DateTime dateTime = DateTime.Parse(fecha);

            //new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month));

            diasMes = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
            return diasMes;
        }

        public static double getPorcentaje(double cantidad, double porcentaje) {
            double cantidadPorcentaje = cantidad * (porcentaje / 100);
            return cantidadPorcentaje;
        }    
        public static bool EsValidoRFC(string text)
        {
            int i = 0;
            while (i < text.Length)
            {
                if ((text.ElementAt(i) < 65) || (text.ElementAt(i) > 90))
                {
                    if ((text.ElementAt(i) < 48) || (text.ElementAt(i) > 57))
                    {                      
                        return false;
                    }
                }
                if ((text.ElementAt(i) < 48) || (text.ElementAt(i) > 57))
                {
                    if ((text.ElementAt(i) < 65) || (text.ElementAt(i) > 90))
                    {
                   return false;
                    }
                }
                i++;
            }

            if (text.Length < 13)
            {
                return false;
            }
            if (text.Length > 13)
            {
                return false;
            }
            return true;
        }
        


        public static bool EsValidoCURP(string text)
        {
            int i = 0;
            while (i < text.Length)
            {
                if ((text.ElementAt(i) < 65) || (text.ElementAt(i) > 90))
                {
                    if ((text.ElementAt(i) < 48) || (text.ElementAt(i) > 57))
                    {
                        return false;
                    }
                }
                if ((text.ElementAt(i) < 48) || (text.ElementAt(i) > 57))
                {
                    if ((text.ElementAt(i) < 65) || (text.ElementAt(i) > 90))
                    {
                        return false;
                    }
                }
                i++;
            }

            if (text.Length < 18)
            {
                return false;
            }
            if (text.Length > 18)
            {
                return false;
            }
            return true;
        }



        public static string NumeroALetras(string text)
        {
            string dec;
            int number;
            bool isParsable = Int32.TryParse(text, out number);
            //var entero = Convert.ToInt64(Math.Truncate(number));
            //var decimales = Convert.ToInt32(Math.Round((text - number) * 100, 2));
            if (number > 0)
            {
                //dec = " PESOS CON " + decimales.ToString() + "/100";
                dec = $" PESOS {number:0,0}" ;
            }
            //Código agregado por mí
            else
            {
                //dec = " PESOS CON " + decimales.ToString() + "/100";
                dec = $" PESOS {number:0,0}";
            }
            var res = NumeroALetras(Convert.ToDouble(text)) + dec;
            return res;
        }
        //[SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
        private static string NumeroALetras(double value)
        {
            string num2Text =""; 
            value = Math.Truncate(value);
            if (value == 0) num2Text = "CERO";
            else if (value == 1) num2Text = "UNO";
            else if (value == 2) num2Text = "DOS";
            else if (value == 3) num2Text = "TRES";
            else if (value == 4) num2Text = "CUATRO";
            else if (value == 5) num2Text = "CINCO";
            else if (value == 6) num2Text = "SEIS";
            else if (value == 7) num2Text = "SIETE";
            else if (value == 8) num2Text = "OCHO";
            else if (value == 9) num2Text = "NUEVE";
            else if (value == 10) num2Text = "DIEZ";
            else if (value == 11) num2Text = "ONCE";
            else if (value == 12) num2Text = "DOCE";
            else if (value == 13) num2Text = "TRECE";
            else if (value == 14) num2Text = "CATORCE";
            else if (value == 15) num2Text = "QUINCE";
            else if (value < 20) num2Text = "DIECI" + NumeroALetras(value - 10);
            else if (value == 20) num2Text = "VEINTE";
            else if (value < 30) num2Text = "VEINTI" + NumeroALetras(value - 20);
            else if (value == 30) num2Text = "TREINTA";
            else if (value == 40) num2Text = "CUARENTA";
            else if (value == 50) num2Text = "CINCUENTA";
            else if (value == 60) num2Text = "SESENTA";
            else if (value == 70) num2Text = "SETENTA";
            else if (value == 80) num2Text = "OCHENTA";
            else if (value == 90) num2Text = "NOVENTA";
            else if (value < 100) num2Text = NumeroALetras(Math.Truncate(value / 10) * 10) + " Y " + NumeroALetras(value % 10);
            else if (value == 100) num2Text = "CIEN";
            else if (value < 200) num2Text = "CIENTO " + NumeroALetras(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) num2Text = NumeroALetras(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) num2Text = "QUINIENTOS";
            else if (value == 700) num2Text = "SETECIENTOS";
            else if (value == 900) num2Text = "NOVECIENTOS";
            else if (value < 1000) num2Text = NumeroALetras(Math.Truncate(value / 100) * 100) + " " + NumeroALetras(value % 100);
            else if (value == 1000) num2Text = "MIL";
            else if (value < 2000) num2Text = "MIL " + NumeroALetras(value % 1000);
            else if (value < 1000000)
            {
                num2Text = NumeroALetras(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0)
                {
                    num2Text = num2Text + " " + NumeroALetras(value % 1000);
                }
            }
            else if (value == 1000000)
            {
                num2Text = "UN MILLON";
            }
            else if (value < 2000000)
            {
                num2Text = "UN MILLON " + NumeroALetras(value % 1000000);
            }
            else if (value < 1000000000000)
            {
                num2Text = NumeroALetras(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0)
                {
                    num2Text = num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000) * 1000000);
                }
            }
            return num2Text;
        
    }

        public static int SUELDOMENSUAL(string fecha)
        {
            int diasMes = 0;
            DateTime dateTime = DateTime.Parse(fecha);

            //new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month));

            diasMes = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
            return diasMes;
        }

    }

    public static class calculoNomina {

       
    }

}
