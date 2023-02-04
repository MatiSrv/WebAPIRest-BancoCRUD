using Aplicacion.Datos.Interfaces;
using Aplicacion.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Datos.Implementacion
{
    public class CRUDcuentas : ICuentas
    {
        public bool Alta(Cuenta c)
        {
            return HelperDB.GetInstance().InsertCta("SP_InsertCuenta", c);
        }

        public bool Baja(int c)
        {
            return HelperDB.GetInstance().BajaCta("SP_DeleteCuenta", c);
        }

        public List<Cuenta> Cargar_Cuentas()
        {
            List<Cuenta> lCuentas = new List<Cuenta>();
            DataTable dt = HelperDB.GetInstance().Consulta("SP_Cuentas");

            foreach (DataRow dr in dt.Rows)
            {
                Cuenta c = new Cuenta();
                c.CodCuenta = Convert.ToInt32(dr["cod_cuenta"]);
                c.TipoCuenta = dr["tipo"].ToString();
                c.CodTipoCuenta = Convert.ToInt32(dr["cod_tipo_cuenta"]);
                c.Cbu = Convert.ToInt64(dr["cbu"]);
                c.Saldo = Convert.ToDouble(dr["saldo"]);
                c.UltimoMovimiento = Convert.ToDateTime(dr["UltimoMovimiento"]);
                c.NombreCli = dr["Nombre"].ToString();
                c.CodCli = Convert.ToInt32(dr["cod_cliente"]);
               

                lCuentas.Add(c);
            }
       
            return lCuentas;
        }

        public List<Cuenta> Cargar_CuentasCLI(int dni)
        {
            List<Cuenta> lCuentas = new List<Cuenta>();
            DataTable dt = HelperDB.GetInstance().FiltroCliente("SP_FiltroCli", dni);

            foreach (DataRow dr in dt.Rows)
            {
                Cuenta c = new Cuenta();
                c.CodCuenta = Convert.ToInt32(dr["cod_cuenta"]);
                c.TipoCuenta = dr["tipo"].ToString();
                c.CodTipoCuenta = Convert.ToInt32(dr["cod_tipo_cuenta"]);
                c.Cbu = Convert.ToInt64(dr["cbu"]);
                c.Saldo = Convert.ToDouble(dr["saldo"]);
                c.UltimoMovimiento = Convert.ToDateTime(dr["UltimoMovimiento"]);
                c.NombreCli = dr["Nombre"].ToString();
                c.CodCli = Convert.ToInt32(dr["cod_cliente"]);


                lCuentas.Add(c);
            }

            return lCuentas;
        }

        


        public List<Cuenta> Cargar_CuentasFEC(DateTime desde, DateTime hasta)
        {
            List<Cuenta> lCuentas = new List<Cuenta>();
            DataTable dt = HelperDB.GetInstance().FiltroFecha("SP_FiltroFecha", desde,hasta);

            foreach (DataRow dr in dt.Rows)
            {
                Cuenta c = new Cuenta();
                c.CodCuenta = Convert.ToInt32(dr["cod_cuenta"]);
                c.TipoCuenta = dr["tipo"].ToString();
                c.CodTipoCuenta = Convert.ToInt32(dr["cod_tipo_cuenta"]);
                c.Cbu = Convert.ToInt64(dr["cbu"]);
                c.Saldo = Convert.ToDouble(dr["saldo"]);
                c.UltimoMovimiento = Convert.ToDateTime(dr["UltimoMovimiento"]);
                c.NombreCli = dr["Nombre"].ToString();
                c.CodCli = Convert.ToInt32(dr["cod_cliente"]);


                lCuentas.Add(c);
            }

            return lCuentas;
        }

        public List<Cuenta> Cargar_CuentasTC(string tc)
        {
            List<Cuenta> lCuentas = new List<Cuenta>();
            DataTable dt = HelperDB.GetInstance().FiltroTipoCta("SP_FiltroTipoCta",tc);

            foreach (DataRow dr in dt.Rows)
            {
                Cuenta c = new Cuenta();
                c.CodCuenta = Convert.ToInt32(dr["cod_cuenta"]);
                c.TipoCuenta = dr["tipo"].ToString();
                c.CodTipoCuenta = Convert.ToInt32(dr["cod_tipo_cuenta"]);
                c.Cbu = Convert.ToInt64(dr["cbu"]);
                c.Saldo = Convert.ToDouble(dr["saldo"]);
                c.UltimoMovimiento = Convert.ToDateTime(dr["UltimoMovimiento"]);
                c.NombreCli = dr["Nombre"].ToString();
                c.CodCli = Convert.ToInt32(dr["cod_cliente"]);


                lCuentas.Add(c);
            }

            return lCuentas;
        }
    }
}
