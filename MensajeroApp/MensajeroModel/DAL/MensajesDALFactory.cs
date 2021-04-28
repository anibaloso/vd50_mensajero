using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeroModel.DAL
{
    public class MensajesDALFactory
    {
        //como necesito crear un solo objeto en este momento 

        public static IMensajesDAL CreateDAL()
        {
            return MensajesDALArchivos.GetInstance();
        }
    }
}
