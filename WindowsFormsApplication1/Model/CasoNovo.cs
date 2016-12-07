using SojaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    class CasoNovo:Caso
    {
        private static CasoNovo singleton = null;

        private CasoNovo() { }

        public static CasoNovo getInstance()
        {
            if (singleton == null)
            {
                singleton = new CasoNovo();

                return singleton;
            }

            return singleton;
        }
        public void limpa()
        {
            singleton = null;
        }
    }
}
