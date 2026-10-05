using System;
using System.Collections.Generic;
using System.Text;
using GestionGastos.DAO;
using GestionGastos.Models;

using System.Collections.Generic;
using GestionGastos.DAO;
using GestionGastos.Models;

namespace GestionGastos.Controllers
{
    public class GastoController
    {
        private GastoDAO gastoDAO = new GastoDAO();

        public GastoController()
        {
            gastoDAO.CrearTabla(); 
        }

        public void Registrar(Gasto gasto)
        {
            gastoDAO.InsertarGasto(gasto);
        }

        public void Actualizar(Gasto gasto)
        {
            gastoDAO.Editar(gasto);  
        }

        public List<Gasto> ListarGasto()
        {
            return gastoDAO.Lista(); 
        }

        public void Eliminar(int id)
        {
            gastoDAO.Eliminar(id); 
        }
    }
}