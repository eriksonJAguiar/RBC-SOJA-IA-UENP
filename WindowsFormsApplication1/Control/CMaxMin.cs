using SojaApp.DAO;
using SojaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Control
{
    class CMaxMin
    {
        public double valAtributo(String atrib, String val)
        {
            DaoAtributo at = new DaoAtributo();

            Atributo atb = new Atributo();
            atb.atributo = atrib;

            Atributo atb2 = at.searchOther(atb);
            double valor = 0;

            int i = atb2.valor2.IndexOf(val);

            if (i > 0)
                valor = Convert.ToDouble(atb2.valor1[i]);


            return valor;

        }
        public List<double> maxMinCol(List<Caso> casos, PropertyInfo atbTab)
        {

            PropertyInfo[] nomeAtribs = casos[0].GetType().GetProperties();


            List<double> valores = new List<double>();
            

            PropertyInfo[] prop;


            for (int i = 0; i < casos.Count; i++)
            {
                prop = casos[i].GetType().GetProperties();

                for (int j = 3; j < prop.Length-1; j++)
                {

                    if (prop[j].Name.Equals(atbTab.Name))
                    {
                        var v = prop[j].GetValue(casos[i]);

                        valores.Add(valAtributo(prop[j].Name, (String)v));
                    }
                }

            }

            return valores;

        }
    }
}
