using Aplicacion.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Servicios.Interfaces;

public interface IServicio
{
    List<Cliente> ListClientes();
    List<Cuenta> Cuentas();

    List<Cuenta> Cargar_CuentasTC(string tc);
    List<Cuenta> Cargar_CuentasCLI(int dni);
    List<Cuenta> Cargar_CuentasFEC(DateTime desde, DateTime hasta);

    bool BajaCliente(int c);
    bool AltaCli(Cliente c);    
    bool Modificacion(Cliente c);
    bool TieneCuentas(int c);


    bool AltaCta(Cuenta c);
    
    bool BajaCuenta(int c);
}
