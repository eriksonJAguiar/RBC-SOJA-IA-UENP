using SojaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    class CasoSingleton:Caso
    {
        private static CasoSingleton singleton = null;

        private CasoSingleton() { }

        public static CasoSingleton getInstance()
        {
            if(singleton == null)
            {
                singleton = new CasoSingleton();

                return singleton;
            }

            return singleton;
        }
    }
}
