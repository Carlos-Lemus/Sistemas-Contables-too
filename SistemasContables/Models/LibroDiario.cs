using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.Models
{
    public class LibroDiario
    {
        private int idLibroDiario;
        private string periodo;
        private double cajaChica;
        private double banco;

        public int IdLibroDiario
        {
            get
            {
                return this.idLibroDiario;
            }
            set
            {
                this.idLibroDiario = value;
            }
        }

        public string Periodo
        {
            get
            {
                return this.periodo;
            }
            set
            {
                this.periodo = value;
            }
        }

        public double CajaChica
        {
            get
            {
                return this.cajaChica;
            }
            set
            {
                this.cajaChica = value;
            }
        }

        public double Banco
        {
            get
            {
                return this.banco;
            }
            set
            {
                this.banco = value;
            }
        }

    }
}
