using MongoDB.Driver;
using MongoDB.Driver.Builders;
using SojaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SojaApp.DAO
{
    class DaoPeso : GenericDao<Peso>
    {
        private static string connect = "mongodb://localhost:27017";


        private MongoServer server;
        private MongoCollection<Peso> coll;
        private MongoDatabase database;

        public DaoPeso()
        {
            var cliente = new MongoDB.Driver.MongoClient(connect);

            server = cliente.GetServer();

            database = server.GetDatabase("sojaBD");


            coll = database.GetCollection<Peso>("pesos");
        }

        public bool create(Peso t)
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

        public bool delete(Peso t)
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

        public Peso search(Peso t)
        {
            try
            {
                //var q = Query.EQ("atributo", t.atributo);
                var result = coll.FindOneAs<Peso>();

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

        public List<Peso> getAll()
        {
            try
            {
                MongoCursor<Peso> result = coll.FindAll();

                List<Peso> lPeso = new List<Peso>();

                foreach (Peso p in result)
                {
                    lPeso.Add(p);
                }

                return lPeso;
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

        public Peso searchOther(Peso t)
        {

            try
            {
                String at = t.atributo.Replace("_", "-");
                var q = Query.EQ("atributo", at);
                MongoCursor<Peso> result = coll.Find(q);

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
