using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiteDB;

namespace BlazorCounter.Data
{
    public class DataContext<T> where T : class
    {
        private string _nameCollection { get; set; }
        private string _pathToDb = "mydata.db";
        
        public DataContext()
        {
            _nameCollection = typeof(T).Name;
            // _pathToDb = '';
        }

        protected T Insert(T item)
        {
            using (var db = new LiteDatabase(_pathToDb))
            {
                // Get a collection (or create, if doesn't exist)
                var col = db.GetCollection<T>(_nameCollection);
                // Insert new customer document (Id will be auto-incremented)
                col.Insert(item);
            }
            return item;
        }

        protected List<T> GetAll()
        {
            using (var db = new LiteDatabase(_pathToDb))
            {
                // Get a collection (or create, if doesn't exist)
                var col = db.GetCollection<T>(_nameCollection);
                // Insert new customer document (Id will be auto-incremented)
                var result = col.FindAll();
                return result.ToList();
            }
        }
    }
}
