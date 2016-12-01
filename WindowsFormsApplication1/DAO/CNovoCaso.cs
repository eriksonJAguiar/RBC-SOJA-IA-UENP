using SojaApp.DAO;
using SojaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DAO
{
    class CNovoCaso
    {
        public bool gravaNovoCaso(Caso caso)
        {
            DaoCaso dao = new DaoCaso();

            Caso c = caso;

            if (dao.create(c))
            {
                Console.WriteLine("Gravado com sucesso");
                return true;
            }
            return false;
        }
    }
}
