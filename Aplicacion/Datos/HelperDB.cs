using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Aplicacion.Dominio;
using System.Data.SqlClient;

namespace Aplicacion.Datos
{
    public class HelperDB
    {
        private static HelperDB Instancia;
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-MOJB65U\SQLEXPRESS;Initial Catalog=BancoDB;Integrated Security=True");
        public static HelperDB GetInstance()
        {
            if (Instancia == null)
                Instancia = new HelperDB();
            return Instancia;
        }

        public int Logeo(string user, string pass)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_LOGIN", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@User", user);
                cmd.Parameters.AddWithValue("@Pass", pass);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return dr.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }
            finally
            {
                cnn.Close();
            }
            return -1;
        }

        public DataTable Consulta(string Sp)
        {
            DataTable dt = new DataTable();
            if(cnn.State==ConnectionState.Closed)
                cnn.Open();

            SqlCommand cmd = new SqlCommand(Sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            dt.Load(cmd.ExecuteReader());
            cnn.Close();

            return dt;
        }

        public bool InsertCli(string sp,Cliente c)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", c.Apellido);
            cmd.Parameters.AddWithValue("@Dni", c.Dni);

            int afectadas = cmd.ExecuteNonQuery();
            cnn.Close();
            return afectadas > 0;

        }

        public bool Baja(string sp,int id)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sp,cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dni", id);
            int afectadas = cmd.ExecuteNonQuery();
            cnn.Close();
            return afectadas > 0;

        }

        public bool UpdateCli(string sp,Cliente c)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nom", c.Nombre);
            cmd.Parameters.AddWithValue("@ape", c.Apellido);
            cmd.Parameters.AddWithValue("@dni", c.Dni);
            cmd.Parameters.AddWithValue("@id", c.Id);

            int afectadas = cmd.ExecuteNonQuery();
            cnn.Close();
            return afectadas > 0;
        }
        public bool TieneCuentas(string sp,int c)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", c);

            int filas = cmd.ExecuteNonQuery();
            cnn.Close();
            return filas>0;
        }

        /*--------------------------------------------------------------------------------------------------------------------------------
         ----------------------------------------------------------------CUENTAS-----------------------------------------------------------
        -------------------------------------------------------------------------------------------------------------------------*/

         public bool InsertCta(string sp, Cuenta c)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cbu", c.Cbu);
            cmd.Parameters.AddWithValue("@saldo", c.Saldo);
            cmd.Parameters.AddWithValue("@cod_tipo_cuenta", c.CodTipoCuenta);
            cmd.Parameters.AddWithValue("@ultimomovimiento", c.UltimoMovimiento);
            cmd.Parameters.AddWithValue("@cod_cliente", c.CodCli);
            cmd.Parameters.AddWithValue("@estado", 1);
           

            int afectadas = cmd.ExecuteNonQuery();
            cnn.Close();
            return afectadas > 0;

        }

        public bool BajaCta(string sp, int cod)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_cuenta", cod);
            int afectadas = cmd.ExecuteNonQuery();
            cnn.Close();
            return afectadas > 0;

        }
        /*--------------------------------------------------------------------------------------------------------------------------------
         ----------------------------------------------------------------FILTROS-----------------------------------------------------------
        -------------------------------------------------------------------------------------------------------------------------*/
        public DataTable FiltroTipoCta(string Sp,string nombre)
        {
            DataTable dt = new DataTable();
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            SqlCommand cmd = new SqlCommand(Sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TipoCuenta", nombre);
            dt.Load(cmd.ExecuteReader());
            cnn.Close();

            return dt;
        }
        public DataTable FiltroCliente(string Sp, int dni)
        {
            DataTable dt = new DataTable();
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            SqlCommand cmd = new SqlCommand(Sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dni", dni);
            dt.Load(cmd.ExecuteReader());
            cnn.Close();

            return dt;
        }
        public DataTable FiltroFecha(string Sp, DateTime desde,DateTime hasta)
        {
            DataTable dt = new DataTable();
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            SqlCommand cmd = new SqlCommand(Sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@desde", desde);
            cmd.Parameters.AddWithValue("@hasta", hasta);
            dt.Load(cmd.ExecuteReader());
            cnn.Close();

            return dt;
        }
    }
}
