using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Proyecto.Controler;

namespace Proyecto.Model
{
    internal class departamentosModel
    {
        conexionModel conexion;

        public departamentosModel()
        {

            conexion = new conexionModel();

        }

        public bool agregar()
        {
            return conexion.ejecutarSinRetornoDatos("INSERT INTO Departamentos (departamento) VALUES ('Programacion')");

        }

    }
}
