
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Lists
    {
        public class Departamento
        {
            public string nomDepa { get; set; }
            public string sueldoBase { get; set; }
        }

        public class Puesto
        {
            public string nomPuesto { get; set; }
            public string proporSal { get; set; }

        }


    public class Usuario
    {
        public string usuario { get; set; }
        public string tipous { get; set; }
        public string contra { get; set; }
    }

    public class Empleado
        {

            public Guid ID_Empleado { get; set; }
            public string nombre { get; set; }
            public string apellidos { get; set; }
            public string fechaAlta { get; set; }
            public int edad { get; set; }
            public string depa { get; set; }
            public string puesto { get; set; }
            public string fechaNacimiento { get; set; }
            public string CURP { get; set; }
            public string NSS { get; set; }
            public string RFC { get; set; }
            public string domicilio { get; set; }
            public string banco { get; set; }
            public string numCuenta { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
            public string contra { get; set; }

    }
        public class Empresa
        {
            public string razon_social { get; set; }
            public string nombreEmp { get; set; }
            public string domicilioFis { get; set; }
            public string datosEmpCont { get; set; }
            public string regPat { get; set; }
            public string RFC_EMP { get; set; }
            public string inicioOp { get; set; }

        }
    public class PERDEC
    {
        public string tipoDato { get; set; }
        public string conceptoPD { get; set; }
        public string porcentPD { get; set; }
        public string monto { get; set; }

    }

    public class NOMINA
        {
            public Guid numemp { get; set; }
        public string fechanom { get; set; }
        public string nomemple { get; set; }
            public List<string> percep { get; set; }
            public string perpepT { get; set; }
            public List<string> deducc { get; set; }
        public string deduccT { get; set; }
        public double sueldoB { get; set; }
            public double sueldoN { get; set; }
            public int jornada { get; set; }
            public string depa { get; set; }
            public string puesto { get; set; }
    
    }

    public class listapercep
    {
        public Guid idemp { get; set; }
        public string fechanom { get; set; }
        public string tipo { get; set; }
        public string nom { get; set; }
        public double monto { get; set; }

    }

    public class listadeduc
    {

        public Guid idemp { get; set; }
        public string fechanom { get; set; }
        public string tipo { get; set; }
        public string nom { get; set; }
        public double monto { get; set; }
    }
    public class RECIBO
        {
        public string numemp { get; set; }
        public string nomemple { get; set; }
        public string fechanom { get; set; }
        public string percept { get; set; }
        public string deducc { get; set; }
        public string NumRec { get; set; }
        public string sueldoB { get; set; }
        public string sueldoN { get; set; }
        public string jornada { get; set; }
        public string fechaAlta { get; set; }
            public string depa { get; set; }
            public string puesto { get; set; }
            public string sueldoNletra { get; set; }
            public string RegPat { get; set; }
            public string RFC_emple { get; set; }
            public string RFC_EMP { get; set; }
            public string inicioOp { get; set; }
            public string razon_social { get; set; }
            public string nomEmpresa { get; set; }
        }

    public class REPORTE_GEN_NOM
    {
        public string depa { get; set; }
        public string puesto { get; set; }
        public string fechanom { get; set; }
        public string nomemple { get; set; }
        public int edad { get; set; }
        public float salDiario { get; set; }
     

    }

    public class REPORTE_HEADCOUNTER
    {
        public string depa { get; set; }
        public string puesto { get; set; }
        public int anio { get; set; }
        public int mes { get; set; }
        public string cantEmple { get; set; }
        public string nombreEmp { get; set; }

    }
    public class REPORTE_NOM
    {
        public string sumpercep { get; set; }
        public string sumdeducc { get; set; }
        public string depa { get; set; }
        public string sumSueldoN { get; set; }
        public string sumSueldoB { get; set; }
        public int anio { get; set; }
        public int mes { get; set; }

    }

}

