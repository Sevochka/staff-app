using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffApp
{
    public class DB
    {
        readonly MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=is-staff");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public DataTable getEmployees()
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT personal_number AS 'Таб.номер', name AS 'Имя', surname AS 'Фамилия' FROM `employee`", this.getConnection());
            this.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table;
        }

        public DataTable getDepartments()
        {
            this.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT department_code, name FROM `department`", this.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table;
        }

        public DataTable getPositionsByDepartmentCode(UInt32 code)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT position_id FROM `deppos` WHERE `department_code` = @uCode", this.getConnection());
            command.Parameters.Add("@uCode", MySqlDbType.VarChar).Value = code;
            this.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table;
        }

        public DataTable getPositionByCode(int code)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT name FROM `position` WHERE `position_code` = @uCode", this.getConnection());
            command.Parameters.Add("@uCode", MySqlDbType.VarChar).Value = code;
            this.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table;
        }

    }
}
