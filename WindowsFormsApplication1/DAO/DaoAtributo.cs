using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using SojaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SojaApp.DAO
{
    class DaoAtributo : GenericDao<Atributo>
    {
        private static string connect = "mongodb://localhost:27017";

        
        private MongoServer server;
        private MongoCollection<Atributo> coll;
        private MongoDatabase database;

        public DaoAtributo()
        {
            var cliente = new MongoDB.Driver.MongoClient(connect);

            server = cliente.GetServer();

            database = server.GetDatabase("sojaBD");


            coll = database.GetCollection<Atributo>("atrib_values");

        }
        public bool create(Atributo t)
        {
            try
            {
                coll.Insert(t);

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                server.Disconnect();   
            }
        }

        public bool delete(Atributo t)
        {
            try
            {
                var q = Query.EQ("_id", t._id);
                coll.Remove(q);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                server.Disconnect();
            } 
        }
       public Atributo search(Atributo t)
        {

            try
            {
               var q = Query.EQ("atributo", t.atributo);
               var result = coll.FindOneAs<Atributo>();

                return result;
            }
            catch (Exception e )
            {
                Console.WriteLine(e.Message);

                return null;
            }
            finally
            {
                server.Disconnect();
            }
           
        }

        public List<Atributo> getAll()
        {
            try
            {

                MongoCursor<Atributo> result = coll.FindAll();

                List<Atributo> lAtrb = new List<Atributo>();

               foreach(Atributo r in result){
                    lAtrb.Add(r);
                }

                return lAtrb;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
            finally
            {
                server.Disconnect();
            }
        }
        public Atributo searchOther(Atributo t)
        {

            try
            {
               String at = t.atributo.Replace("_","-");
                var q = Query.EQ("atributo", at);
                MongoCursor<Atributo> result = coll.Find(q);

                return result.First();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
            finally
            {
                server.Disconnect();
            }

        }
    }
}
