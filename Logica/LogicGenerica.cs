using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class LogicGenerica
    {
        DAOGenerica dao = new DAOGenerica();

        public int ObtenerTotalRegistros(String tabla)
        {
            return dao.ObtenerTotalRegistros(tabla);
        }

        public string ObtenerCodigoEntidad(string nombreTabla, string codigoGenerar)
        {
            if(codigoGenerar =="E")
            {
                return dao.ObtenerCodigoEntidad(nombreTabla);
            }else if (codigoGenerar == "DAO")
            {
                return dao.ObtenerCodigoDAO(nombreTabla);
            }
            else
            {
                return dao.ObtenerCodigoSP(nombreTabla);
            }
    
        }

        public List<string> ListarTablas()
        {
            return dao.ListaTablas();
        }
    }
}
