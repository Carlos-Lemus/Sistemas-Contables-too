using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables
{
    public class CuentasController
    {
        private CuentasDAO cuentasDAO;
        private List<Cuenta> lista;
        private bool estado = false;

        public CuentasController()
        {
            this.cuentasDAO = new CuentasDAO();
        }

        public List<Cuenta> getList()
        {
            this.lista = this.cuentasDAO.getList();

            return this.lista;
        }

        public bool agregarCuenta(Cuenta cuenta)
        {
            this.estado = this.cuentasDAO.agregarCuenta(cuenta);
            return this.estado;
        }

        public bool agregarListaDeCuentas(List<Cuenta> listCuentas)
        {
            this.estado = this.cuentasDAO.agregarListaDeCuentas(listCuentas);
            return this.estado;
        }

        public List<Cuenta> listaNivelTipo(int nivel, string tipo)
        {
            this.lista = this.cuentasDAO.listaNivelTipo(nivel, tipo);

            return this.lista;
        }

        public List<Cuenta> listaNivel(int nivel)
        {
            this.lista = this.cuentasDAO.listaNivel(nivel);

            return this.lista;
        }

        public bool update(Cuenta cuenta)
        {
            return this.cuentasDAO.update(cuenta);
        }

        public bool delete(int idCuenta)
        {
            return this.cuentasDAO.delete(idCuenta);
        }

    }
}
