using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class LogicListaValoresCabecera
    {
        DAOListaValoresCabecera dao = new DAOListaValoresCabecera();



        public bool Insertar(ListaValoresCabecera obj)
        {
            return dao.Insertar(obj);
        }
        public bool Actualizar(ListaValoresCabecera obj)
        {
            return dao.Actualizar(obj);
        }
        public bool Eliminar(int id)
        {
            return dao.Eliminar(id);
        }
        public List<ListaValoresCabecera> Paginacion(int pagina, int registros,ListaValoresCabecera obj,out int totalRegistros)
        {
            return dao.Paginacion(pagina,registros,obj, out totalRegistros);
        }

        public ListaValoresCabecera Obtener(int id)
        {
            return dao.Obtener(id);
        }

    }
}
