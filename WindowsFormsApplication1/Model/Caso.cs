using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SojaApp.Model
{
    [BsonIgnoreExtraElements()]
    class Caso
    {
        [BsonId]
        public ObjectId _id { get; set; }
        
        [BsonElement("Caso")]
        public int caso { get; set; }

        [BsonElement("DescDoenca")]
        public String doenca { get; set; }

        [BsonElement("area_damaged")]
        public String area_damaged { get; set; }

        [BsonElement("canker_lesion")]
        public String canker_lesion { get; set; }

        [BsonElement("crop_hist")]
        public String crop_hist { get; set; }

        [BsonElement("date")]
        public String date { get; set; }

        [BsonElement("external decay")]
        public String external_decay { get; set; }

        [BsonElement("fruit spots")]
        public String fruit_spots { get; set; }

        [BsonElement("fruiting_bodies")]
        public String fruiting_bodies { get; set; }

        [BsonElement("fruit_pods")]
        public String fruit_pods { get; set; }

        [BsonElement("germination")]
        public String germination { get; set; }

        [BsonElement("hail")]
        public String hail { get; set; }

        [BsonElement("int_discolor")]
        public String int_discolor { get; set; }

        [BsonElement("leaf_malf")]
        public String leaf_malf { get; set; }

        [BsonElement("leaf_mild")]
        public String leaf_mild { get; set; }

        [BsonElement("leaf_shread")]
        public String leaf_shread { get; set; }

        [BsonElement("leafspots_halo")]
        public String leafspots_halo { get; set; }

        [BsonElement("leafspot_size")]
        public String leafspots_size { get; set; }

        [BsonElement("leafspots_marg")]
        public String leafspots_marg { get; set; }

        [BsonElement("leaves")]
        public String leaves { get; set; }

        [BsonElement("lodging")]
        public String lodging { get; set; }

        [BsonElement("mold_growth")]
        public String mold_growth { get; set; }

        [BsonElement("mycelium")]
        public String mycelium { get; set; }

        [BsonElement("plant_growth")]
        public String plant_growth { get; set; }

        [BsonElement("plant_stand")]
        public String plant_stand { get; set; }

        [BsonElement("precip")]
        public String precip { get; set; }

        [BsonElement("roots")]
        public String roots { get; set; }

        [BsonElement("sclerotia")]
        public String sclerotia { get; set; }

        [BsonElement("seed")]
        public String seed { get; set; }

        [BsonElement("seed_discolor")]
        public String seed_discolor { get; set; }

        [BsonElement("seed_size")]
        public String seed_size { get; set; }

        [BsonElement("seed_tmt")]
        public String seed_tmt { get; set; }

        [BsonElement("severity")]
        public String severity { get; set; }

        [BsonElement("shriveling")]
        public String shriveling { get; set; }

        [BsonElement("stem")]
        public String stem { get; set; }

        [BsonElement("stem_cankers")]
        public String stem_cankers { get; set; }

        [BsonElement("temp")]
        public String temp { get; set; }

        public double SimilaridadeGlobal { get; set; }
    }
}
