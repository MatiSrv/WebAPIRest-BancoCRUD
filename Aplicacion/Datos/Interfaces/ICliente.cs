using Aplicacion.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aplicacion.Datos.Interfaces
{
    public interface ICliente
    {
        bool Alta (Cliente c);
        bool Baja (int c);
        bool Modificacion (Cliente c);

        List<Cliente> Cargar_Clientes();
        bool TieneCuentas(int c);
    }
}
