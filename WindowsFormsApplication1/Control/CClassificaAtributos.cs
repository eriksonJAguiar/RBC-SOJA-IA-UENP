using SojaApp.DAO;
using SojaApp.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication1.Control
{
    class CClassificaAtributos
    {
        public Hashtable organizarAtributos(Hashtable atrib)
        {
            DaoAtributo atrib_dao = new DaoAtributo();

            List<Atributo> lAtrib = atrib_dao.getAll();


            atrib["area_damaged"].ToString();

            //atrib["canker_laesion"].ToString();



            return null;
        }

        /*atri_casos.Add("area_damaged", c.area_damaged);
                atri_casos.Add("canker_lesion", c.canker_lesion);
                atri_casos.Add("crop_hist", c.crop_hist);
                atri_casos.Add("date", c.date);
                atri_casos.Add("externalDecay", c.externalDecay);
                atri_casos.Add("fruitingBodies", c.fruitingBodies);
                atri_casos.Add("fruitPods", c.fruitPods);
                atri_casos.Add("fruitSpots", c.fruitSpots);
                atri_casos.Add("germination", c.germination);
                atri_casos.Add("hail", c.hail);
                atri_casos.Add("intDiscolor", c.intDiscolor);
                atri_casos.Add("leafShread", c.leafShread);
                atri_casos.Add("leafsports_halo", c.leafsports_halo);
                atri_casos.Add("leafspotMarg", c.leafspotMarg);
                atri_casos.Add("leafspotSize", c.leafspotSize);
                atri_casos.Add("leaf_malf", c.leaf_malf);
                atri_casos.Add("leaf_mild", c.leaf_mild);
                atri_casos.Add("leaves", c.leaves);
                atri_casos.Add("lodging", c.lodging);
                atri_casos.Add("moldGrowth", c.moldGrowth);
                atri_casos.Add("mycelium", c.mycelium);
                atri_casos.Add("plantStand", c.plantStand);
                atri_casos.Add("plant_growth", c.plant_growth);
                atri_casos.Add("precip", c.precip);
                atri_casos.Add("roots", c.roots);
                atri_casos.Add("sclerotia", c.sclerotia);
                atri_casos.Add("seed", c.seed);
                atri_casos.Add("seedDiscolor", c.seedDiscolor);
                atri_casos.Add("seedSize", c.seedSize);
                atri_casos.Add("seedTmt", c.seedTmt);
                atri_casos.Add("severity", c.severity);
                atri_casos.Add("shriveling", c.shriveling);
                atri_casos.Add("stem", c.stem);
                atri_casos.Add("stemCankers", c.stemCankers);
                atri_casos.Add("temp", c.temp);*/

    }
}
