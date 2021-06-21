using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    public class LibroDiariosController
    {

        private LibroDiarioDAO libroDiarioDAO;

        public LibroDiariosController()
        {
            this.libroDiarioDAO = new LibroDiarioDAO();
        }

        public bool insert(LibroDiario libroDiario)
        {
            return libroDiarioDAO.insert(libroDiario);
        }

        public List<LibroDiario> getList()
        {
            return libroDiarioDAO.getList();
        }

        public bool delete(int idLibroDiario)
        {
            return libroDiarioDAO.delete(idLibroDiario);
        }

        public double total(string cuentaCalcular, int idLibroDiario)
        {
            return libroDiarioDAO.total(cuentaCalcular, idLibroDiario);
        }

        public bool updateCajaChica(int idLibroDiario, double monto)
        {
            return libroDiarioDAO.updateCajaChica(idLibroDiario, monto);
        }


        public bool updateBanco(int idLibroDiario, double monto)
        {
            return libroDiarioDAO.updateBanco(idLibroDiario, monto);
        }

        public double getCajaChicaOrBanco(int idLibroDiario, string tipo)
        {
            return libroDiarioDAO.getCajaChicaOrBanco(idLibroDiario, tipo);
        }

    }
}
