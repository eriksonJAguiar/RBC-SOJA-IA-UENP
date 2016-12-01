using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization;

namespace SojaApp.Model
{  
   
    public class Atributo
    {
        
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElement("atributo")]
        public String atributo { get; set; }

        [BsonElement("valor1")]
        public List<String> valor1 { get; set; }

        [BsonElement("valor2")]
        public List<String> valor2 { get; set; }

        [BsonElement("Similaridade")]
        public String similaridade { get; set; }

        //public Peso peso { get; set; }

    }
}
