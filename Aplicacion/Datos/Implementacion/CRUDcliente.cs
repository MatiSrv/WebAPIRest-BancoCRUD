using Aplicacion.Datos.Interfaces;
using Aplicacion.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Datos.Implementacion
{
    public class CRUDcliente : ICliente
    {
        public bool Alta(Cliente c)
        {
            return HelperDB.GetInstance().InsertCli("SP_Insert_Cli", c);
        }

        public bool Baja(int c)
        {
            return HelperDB.GetInstance().Baja("sp_Delete_cli", c);
        }

        public List<Cliente> Cargar_Clientes()
        {
            List<Cliente> lClientes = new List<Cliente>();
            DataTable dt = HelperDB.GetInstance().Consulta("sp_clientes");
            foreach (DataRow dr in dt.Rows)
            {
                Cliente c = new Cliente();
                c.Id = Convert.ToInt32(dr["idCliente"]);
                c.Apellido = dr["Apellido"].ToString();
                c.Nombre = dr["Nombre"].ToString();
                c.Dni = Convert.ToInt32(dr["Documento"]);

                lClientes.Add(c);

            }
            return lClientes;
        }

        public bool Modificacion(Cliente c)
        {
            return HelperDB.GetInstance().UpdateCli("SP_Update_Cli", c);
        }

        public bool TieneCuentas(int c)
        {
            return HelperDB.GetInstance().TieneCuentas("SP_TieneCuentas", c);
        }
    }
}
