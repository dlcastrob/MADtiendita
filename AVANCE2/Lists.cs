
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Lists
{



    public class EMPLEADO
    {

        public int codUs { get; set; }
        public string contra { get; set; }
        public string nombre { get; set; }
        public string curp { get; set; }
        public string fechaNac { get; set; }
        public string numNom { get; set; }
        public string numCue { get; set; }
        public string email { get; set; }
        public string fechaIn { get; set; }
        public bool estado { get; set; }

    }

    public class PRODUCTO
    {

        public int codPro { get; set; }
        public string descrip { get; set; }
        public string unidadMe { get; set; }
        public float costo { get; set; }
        public float precio { get; set; }
        public string fechaAl { get; set; }
        public bool estado { get; set; }


    }
    public class DEPARTAMENTO
    {
        public int codDepa { get; set; }
        public string nomDepa { get; set; }
        public int estado { get; set; }

    }
    public class DEVOLUCION
    {

        public int codDev { get; set; }
        public float total { get; set; }
        public string dano { get; set; }
        public bool estado { get; set; }

    }

    public class PAGO
    {
        public int codPago { get; set; }
        public int cantidad { get; set; }
        public bool estado { get; set; }

    }

    public class INVENTARIO
    {
        public int codIn { get; set; }
        public int puntoRe { get; set; }
        public int uniVen { get; set; }
        public int merma { get; set; }
        public string fechaCam { get; set; }
        public string fechaIn { get; set; }
        public string fechaFin { get; set; }
        public float porcentaje { get; set; }
        public bool estado { get; set; }

    }

    public class LISTA_ART
    {
        public int codList { get; set; }
        public int cantidad { get; set; }
        public bool estado { get; set; }
    }
}