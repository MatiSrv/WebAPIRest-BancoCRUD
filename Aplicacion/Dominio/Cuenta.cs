using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dominio
{
    public class Cuenta
    {
        public long Cbu { get; set; }
        public double Saldo { get; set; }
        public string? TipoCuenta { get; set; }
        public int CodTipoCuenta { get; set; }
        public DateTime UltimoMovimiento { get; set; }
        public string? NombreCli { get; set; }

        public int CodCuenta { get; set; }
        public int CodCli { get; set; }

        
    }
}
