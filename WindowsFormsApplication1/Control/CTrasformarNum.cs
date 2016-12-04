using SojaApp.DAO;
using SojaApp.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.Control
{
    class  CTrasformarNum
    {
        public List<CasoNum> trasnformar(List<Caso> casos)
        {
            DaoAtributo atb_dao = new DaoAtributo();

            PropertyInfo[] valAtb = casos.GetType().GetProperties();

            List<CasoNum> cs = new List<CasoNum>();

            List<Atributo> at = atb_dao.getAll();

            foreach(Caso c in casos)
            {
                
               
            }
            return null;
           
        }
        public List<CasoNum> trasnformar(Caso caso)
        {


            return null;

        }





    }
}
