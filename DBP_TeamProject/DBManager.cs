using DBP_TeamProject;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GookBabProgram
{
    internal class DBManager
    {
        private MySqlConnection connection;

        public static DBManager instance = new DBManager();
        public static DBManager GetInstance() { return instance; }

        public string StrConn =
                "Server=115.85.181.212;" +
                "Database=s5585452;" +
                "Uid=s5585452;" +
                "Pwd=s5585452;" +
                "Charset=utf8";
        public DBManager InitDBManager()
        {
            try
            {
                connection = new MySqlConnection(StrConn);
                connection.Open();
                return instance;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL 연결 오류: " + ex.Message);
                return null;
            }
        }
        public void CloseConnection()
        {
            connection.Close();
        }
        // 글로벌적으로 참여할 수 있는 Connection
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        public int ExecuteNonQueury(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            return cmd.ExecuteNonQuery();
        }
        public bool GetId(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
        public string GetPassword(string query)
        {
            string result = null;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    result = reader.GetString("비밀번호");
                }
                else
                {
                    MessageBox.Show("해당 아이디가 없습니다.");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Query 오류: " + ex.Message);
                return null;
            }
            return result;
        }
        public (string,string) getPasswordAndRate(string query)
        {
            string password = null;
            string position = null;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    password = reader.GetString("비밀번호");
                    position = reader.GetString("직급");
                }
                else
                {
                    MessageBox.Show("해당 아이디가 없습니다.");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Query 오류: " + ex.Message);
            }
            return (password, position);
        }
        public DataTable FindDataTable(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            return dataTable;
        }
        public void DataBinding(string query)
        {
            DataTable dataTable = instance.FindDataTable(query);
            // DataGridView.DataSource = dataTable;
        }
    }
}
