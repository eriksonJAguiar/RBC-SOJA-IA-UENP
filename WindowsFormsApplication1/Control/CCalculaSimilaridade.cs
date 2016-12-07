using SojaApp.DAO;
using SojaApp.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.Control
{
    class CCalculaSimilaridade
    {
        public List<Caso> calculaSimilaridadeLocal(Caso casoBase)
        {
            DaoCaso dao_caso = new DaoCaso();

            List<Caso> allCasos = dao_caso.getAll();

            //Hashtable sl = new Hashtable();

            PropertyInfo[] valCaso = casoBase.GetType().GetProperties();

            DaoAtributo at = new DaoAtributo();

            Atributo atb2 = new Atributo();

            Hashtable pesos = getPesos();

            List<Atributo> atbs = at.getAll();

            List<Caso> casoSimilar = new List<Caso>();

            double similaridadeLocal = 0;
            double similaridadeGlobal = 0;
            double div = 0;

            for (int j=0;j< allCasos.Count;j++)
            {
                Hashtable similaridades = new Hashtable();
                PropertyInfo[] valTab = allCasos[j].GetType().GetProperties();

                similaridadeLocal = 0;
                div = 0;

                for (int i = 3; i <= 37; i++)
                {

                    //atb.atributo = valTab[i].Name;

                    //Atributo atb2 = at.searchOther(atb);

                    atb2 = atbs.Find(a => a.atributo.Equals(valTab[i].Name.Replace('_','-')));

                    

                    if (valCaso[i].GetValue(casoBase).Equals("Desconhecido") || valTab[i].GetValue(allCasos[j]).Equals("Desconhecido"))
                    {
                           similaridadeLocal += 0;
                           
                           //similaridades.Add(valCaso[i].Name, similaridadeLocal);
                    }
                    else if (valCaso[i].GetValue(casoBase).Equals("Desconhecido") && valTab[i].GetValue(allCasos[j]).Equals("Desconhecido"))
                    {
                        similaridadeLocal += (1* Convert.ToDouble(pesos[valTab[i].Name.Replace('_', '-')].ToString()));
                        div += Convert.ToDouble(pesos[valTab[i].Name.Replace('_', '-')].ToString());
                        //similaridades.Add(valCaso[i].Name, similaridadeLocal);
                    }
                    else if (atb2.similaridade.Equals("Não"))
                    {
                        if (valCaso[i].Name.Equals(valTab[i].Name))
                        {
                            similaridadeLocal += (1* Convert.ToDouble(pesos[valTab[i].Name.Replace('_', '-')].ToString()));
                            div += Convert.ToDouble(pesos[valTab[i].Name.Replace('_', '-')].ToString());
                        }                  

                        similaridadeLocal += 0;

                        //similaridades.Add(valCaso[i].Name, similaridadeLocal);

                    }
                    else {

                        var atbVal = valCaso[i].GetValue(casoBase);
                        var atbTabela = valTab[i].GetValue(allCasos[j]);

                        double valorCaso = valAtributo(valCaso[i].Name, (String)atbVal);
                        double valorTab = valAtributo(valTab[i].Name, (String)atbTabela);

                        double[] maxMin = maxMinCol(valCaso[i].Name);

                        /*maxMin[0] = 1;
                        maxMin[1] = 3;*/

                       if(maxMin[0] != maxMin[1])
                        {
                            similaridadeLocal += (1 - ((Math.Abs(valorCaso - valorTab))) / (maxMin[1] - maxMin[0])* Convert.ToDouble(pesos[valTab[i].Name.Replace('_', '-')].ToString()));
                            div += Convert.ToDouble(pesos[valTab[i].Name.Replace('_', '-')].ToString());
                        }

                        else
                        {
                            similaridadeLocal += (1 - (Math.Abs(valorCaso - valorTab))* Convert.ToDouble(pesos[valTab[i].Name.Replace('_', '-')].ToString()));
                            div += Convert.ToDouble(pesos[valTab[i].Name.Replace('_', '-')].ToString());
                        }
                         

                        //similaridades.Add(valCaso[i].Name, similaridadeLocal);
                    }

                }

                //sl.Add(allCasos[j].caso, similaridades);

                similaridadeGlobal = similaridadeLocal / div;

                Caso c = allCasos[j];
                c.SimilaridadeGlobal = similaridadeGlobal;

                casoSimilar.Add(c);


            }
  

            return casoSimilar;
        }
        /*public List<Caso> CCalculaSimilaridadeGeral(Caso casoBase)
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
                    if((double)(t[valAtb[i].Name]) != 0)
                        c.SimilaridadeGlobal += (Convert.ToDouble(t[valAtb[i].Name])) * (Convert.ToDouble(pesos[valAtb[i].Name.Replace('_', '-')].ToString()));
                   
                }
                double soma = c.SimilaridadeGlobal/ div;
                c.SimilaridadeGlobal = c.SimilaridadeGlobal / div;

                casosSimilares.Add(c);
               
            }

            //List<Caso> melhores = selecionaMelhores(casosSimilares);

            return  casosSimilares;



        }*/
        private double valAtributo(String atrib, String val)
        {
            DaoAtributo at = new DaoAtributo();

            Atributo atb = new Atributo();
            atb.atributo = atrib;

            Atributo atb2 = at.searchOther(atb);
                double valor = 0;

                int i = atb2.valor2.IndexOf(val);

            if (i > 0)
                valor = Convert.ToDouble(atb2.valor1[i]);

            //double valor = at.valNumerico(atrib,val);

            return valor;
            
        }
        private double[] maxMinCol(String label)
        {

                MaxMinimos maxMin = MaxMinimos.getInstance();

                List<double> valores = (List<double>) maxMin.table[label];    

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

            List<Peso> pesos = peso_dao.getAll();

            for(int i=0;i<pesos.Count;i++)
            {
                table.Add(pesos[i].atributo, pesos[i].peso);
            }

            return table;

        }


        public List<Caso> selecionaMelhores(List<Caso> casos)
        {
            List<Caso> caso = new List<Caso>();
            foreach(Caso c in casos)
            {
                if(c.SimilaridadeGlobal >= 0.5)
                {
                    caso.Add(c);
                }
            }

            caso.OrderBy(c => c.SimilaridadeGlobal);

            return caso;
        }
    }
}

