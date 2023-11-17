using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBP_TeamProject
{
    internal class Query
    {
        public string query;
        public static Query instance = new Query();
        public static Query GetInstance()
        {
            return instance;
        }

        public Query createTable(string query)
        {
            this.query = "CREATE TABLE " + query;
            return this;
        }
        public Query insert(string query)
        {
            this.query = "INSERT INTO " + query;
            return this;
        }
        public Query values(string query)
        {
            this.query += " VALUES " + query;
            return this;
        }
        public Query on_duplicate_key_update(string query)
        {
            this.query += " ON DUPLICATE KEY UPDATE " + query;
            return this;
        }
        public Query select(string query)
        {
            this.query = "SELECT " + query;
            return this;
        }
        public Query from(string query)
        {
            this.query += " FROM " + query;
            return this;
        }
        public Query where(string query)
        {
            this.query += " WHERE " + query;
            return this;
        }
        public Query update(string query)
        {
            this.query = "UPDATE " + query;
            return this;
        }
        public Query set(string query)
        {
            this.query += " SET " + query;
            return this;
        }
        public Query innerJoin(string query)
        {
            this.query += " INNER JOIN " + query;
            return this;
        }
        public Query leftJoin(string query)
        {
            this.query += " LEFT JOIN " + query;
            return this;
        }
        public Query on(string query)
        {
            this.query += " ON " + query;
            return this;
        }
        public Query groupBy(string query)
        {
            this.query += " GROUP BY " + query;
            return this;
        }
        public Query deleteFrom(string query)
        {
            this.query = "DELETE FROM " + query;
            return this;
        }
        public string exec()
        {
            return this.query;
        }
    }
}
