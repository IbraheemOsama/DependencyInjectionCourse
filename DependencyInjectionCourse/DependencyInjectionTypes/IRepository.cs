using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTypes
{
    public interface IRepository
    {
        string GetData();
    }

    public class MongoDbRepository : IRepository
    {
        public string GetData()
        {
            return "Mongo";
        }
    }

    public class SqlServerDbRepository : IRepository
    {
        public string GetData()
        {
            return "SQL";
        }
    }

    public class TestRepository : IRepository
    {
        public string GetData()
        {
            return "Fake object";
        }
    }
}
