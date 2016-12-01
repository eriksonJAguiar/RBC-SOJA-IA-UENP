using MongoDB.Driver;
using MongoDB.Driver.Builders;
using SojaApp.Model;
using System;
using System.Collections.Generic;

namespace SojaApp.DAO
{
    class DaoCaso : GenericDao<Caso>
    {

        private static string connect = "mongodb://localhost:27017";


        private MongoServer server;
        private MongoDatabase database;
        private MongoCollection<Caso> coll;

        public DaoCaso()
        {
            var cliente = new MongoDB.Driver.MongoClient(connect);

            server = cliente.GetServer();

            database = server.GetDatabase("sojaBD");
        
            //coll = database.GetCollection("casos");

           coll = database.GetCollection<Caso>("casos");
        }


        public bool create(Caso t)
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

        public bool delete(Caso t)
        {
            try
            {
                var q = Query.EQ("_id", t._id);
                coll.Remove(q);
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

        public Caso search(Caso t)
        {
            try
            {
                //var q = Query.EQ("atributo", t.atributo);
                var result = coll.FindOneAs<Caso>();

                return result;
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

        public List<Caso> getAll()
        {
            try
            {
                MongoCursor<Caso> result = coll.FindAll();

                List<Caso> lCaso = new List<Caso>();

                foreach (Caso r in result)
                {
                    lCaso.Add(r);
                }

                return lCaso;
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
        public int numDocumentos()
        {
            return (int) coll.Count();
        }
    }
}
