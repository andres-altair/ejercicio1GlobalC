using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1GlobalC.Servicios
{
    /// <summary>
    /// interfaz encargada de los menus
    /// 02/02/24 - amd
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// metodo que se encarga del menu
        /// 02/02/24 - amd
        /// </summary>
        /// <returns>int (eleecion)</returns>
        public int menu();
    }
}
