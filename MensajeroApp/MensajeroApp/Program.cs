using MensajeroModel.DAL;
using MensajeroModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeroApp
{
    class Program
    {
        static IMensajesDAL dal = MensajesDALFactory.CreateDAL();

        static void Main(string[] args)
        {
            Mensaje m = new Mensaje()
            {
                Nombre = "que pasa choro",
                Detalle = "volvi",
                Tipo = "Aplicacion"
            };

        }
    }
}
