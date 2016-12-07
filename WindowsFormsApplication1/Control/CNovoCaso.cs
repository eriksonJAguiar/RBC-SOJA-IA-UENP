using SojaApp.DAO;
using SojaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Control
{
    class CNovoCaso
    {
        public void gravaNovoCaso(Caso caso)
        {
            DaoCaso dao = new DaoCaso();

            int num = dao.numDocumentos();

            caso.caso = num;

            dao.create(caso);
        }
    }
}
