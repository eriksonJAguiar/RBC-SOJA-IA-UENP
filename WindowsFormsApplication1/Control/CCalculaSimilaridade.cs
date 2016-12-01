using SojaApp.DAO;
using SojaApp.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Control
{
    class CCalculaSimilaridade
    {


        private Hashtable calculaSimilaridadeLocal(Caso casoBase,List<Caso> allCasos)
        {
            List<Caso> casos = allCasos;


            Hashtable sl = new Hashtable();

            PropertyInfo[] valCaso = casoBase.GetType().GetProperties();

            foreach (Caso c in casos)
            {
                Hashtable similaridades = new Hashtable();
                PropertyInfo[] valTab = c.GetType().GetProperties();

                for (int i = 3; i <= 37; i++)
                {
                    DaoAtributo at = new DaoAtributo();

                    Atributo atb = new Atributo();
                    atb.atributo = valTab[i].Name;

                    Atributo atb2 = at.searchOther(atb);

                    double similaridadeLocal;

                    if (atb2.similaridade.Equals("Não") || valCaso[i].GetValue(casoBase).Equals("Desconhecido") || valTab[i].GetValue(c).Equals("Desconhecido"))
                    {
                           similaridadeLocal = 0;
                           similaridades.Add(valCaso[i].Name, similaridadeLocal);
                    }
                    else if (valTab[i].GetValue(c).Equals("Yes") || valTab[i].GetValue(c).Equals("No"))
                    {
                        var t = valCaso[i].GetValue(casoBase);

                        if (t.Equals(valTab[i].GetValue(c)))
                        {
                            similaridadeLocal = 1;
                            similaridades.Add(valCaso[i].Name, similaridadeLocal);
                        }

                        else
                        {
                            similaridadeLocal = 0;
                            similaridades.Add(valCaso[i].Name, similaridadeLocal);
                        }
                            

                    }
                    else {

                        double[] maxMin = maxMinCol(casos, valTab[i]);
                        var atbVal = valCaso[i].GetValue(casoBase);
                        var atbTabela = valTab[i].GetValue(c);
                        similaridadeLocal = 1 - ((Math.Abs(valAtributo(valCaso[i].Name, (String)atbVal) - valAtributo(valTab[i].Name, (String)atbTabela)))) / (maxMin[1] - maxMin[0]);
                        similaridades.Add(valCaso[i].Name, similaridadeLocal);
                    }

                }

                sl.Add(c.caso, similaridades);

            }

            return sl;
        }
        public List<Caso> CCalculaSimilaridadeGeral(Caso casoBase)
        {
            DaoPeso pesoDao = new DaoPeso();

            //List<Peso> pesos = pesoDao.getAll();

            DaoCaso casoDao = new DaoCaso();

            List<Caso> allCasos = casoDao.getAll();



            List<Caso> casosSimilares = new List<Caso>();

            Hashtable sl = calculaSimilaridadeLocal(casoBase, allCasos);

            PropertyInfo[] valAtb = casoBase.GetType().GetProperties();

            Hashtable pesos = getPesos();

            int div = 0;

            foreach (Int32 val in pesos.Values)
            {
                div += val;
            }


           foreach (Caso c in allCasos)
            {
                Hashtable t = (Hashtable) sl[c.caso];

                for(int i=3;i <= 37; i++)
                {
                    c.SimilaridadeGlobal += (Convert.ToDouble(t[valAtb[i].Name].ToString())) * (Convert.ToDouble(pesos[valAtb[i].Name.Replace('_','-')].ToString()));
                    c.SimilaridadeGlobal = c.SimilaridadeGlobal / div;
                }

                casosSimilares.Add(c);
               
            }

            List<Caso> melhores = selecionaMelhores(casosSimilares);

            return melhores;



        }
        private double valAtributo(String atrib, String val)
        {
            DaoAtributo at = new DaoAtributo();

            Atributo atb = new Atributo();
            atb.atributo = atrib;

            Atributo atb2 = at.searchOther(atb);
                int valor = 0;

                int i = atb2.valor2.IndexOf(val);

            if (i > 0)
                valor = Convert.ToInt32(atb2.valor1[i]);
            else
                return 0;

                return valor;
            
        }
        private double[] maxMinCol(List<Caso> casos, PropertyInfo atbTab)
        {
            Hashtable table = new Hashtable();


            PropertyInfo[] nomeAtribs = casos[0].GetType().GetProperties();

                 
                List<double> valores = new List<double>();

                foreach (Caso c in casos)
                {
                    PropertyInfo[] prop = c.GetType().GetProperties();

                    foreach (PropertyInfo p in prop)
                    {
                        if (p.Name.Equals(atbTab.Name))
                        {
                            var v = p.GetValue(c, null);

                            valores.Add(valAtributo(p.Name, (String)v));
                        }
                    }

                }

                valores.Sort();

                double[] valNumerico = new double[2];

                valNumerico[0] = Convert.ToInt32(valores.First());
                valNumerico[1] = Convert.ToInt32(valores.Last());

                return valNumerico;
    
        }
        private Hashtable getPesos()
        {
            Hashtable table = new Hashtable();

            DaoPeso peso_dao = new DaoPeso();

            List<Peso> peso = peso_dao.getAll();

            foreach(Peso p in peso)
            {
                table.Add(p.atributo, p.peso);
            }

            return table;

        }


        private List<Caso> selecionaMelhores(List<Caso> casos)
        {
            List<Caso> caso = new List<Caso>();
            foreach(Caso c in casos)
            {
                if(c.SimilaridadeGlobal >= 0.5)
                {
                    caso.Add(c);
                }
            }

            return caso;
        }
    }
}

