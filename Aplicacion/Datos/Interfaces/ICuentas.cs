using Aplicacion.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Datos.Interfaces
{
    public interface ICuentas
    {
        bool Alta(Cuenta c);
        bool Baja(int c);
        

        List<Cuenta> Cargar_Cuentas();
        List<Cuenta> Cargar_CuentasTC(string tc);
        List<Cuenta> Cargar_CuentasCLI(int dni);
        List<Cuenta> Cargar_CuentasFEC(DateTime desde,DateTime hasta);
    }
}
