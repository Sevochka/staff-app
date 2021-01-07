using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void addEmployee(string name, string surname, string patronymic, string sex, 
            string family, string education, int seniority, int deppos_code, uint department_code, int position_code)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `employee` " +
                "(`name`, `surname`, `patronymic`, `sex`, " +
                "`family_status`, `education`, `seniority`, `deppos_id`, `department_code`, `position_code`) " +
                "VALUES (@name, @surname, @patronymic, @sex, @family_status, @education, " +
                "@seniority, @deppos_id, @department_code, @position_code);", this.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname;
            command.Parameters.Add("@patronymic", MySqlDbType.VarChar).Value = patronymic;
            command.Parameters.Add("@sex", MySqlDbType.VarChar).Value = sex;
            command.Parameters.Add("@family_status", MySqlDbType.VarChar).Value = family;
            command.Parameters.Add("@education", MySqlDbType.VarChar).Value = education;
            command.Parameters.Add("@seniority", MySqlDbType.VarChar).Value = seniority;
            command.Parameters.Add("@deppos_id", MySqlDbType.VarChar).Value = deppos_code;
            command.Parameters.Add("@department_code", MySqlDbType.VarChar).Value = department_code;
            command.Parameters.Add("@position_code", MySqlDbType.VarChar).Value = position_code;

            this.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Добавлено успешно");
            }
            else
            {
                MessageBox.Show("Что-то пошло не так");
            }
            this.closeConnection();
        }

        public DataTable getEmployeeInfo(uint id)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `employee` WHERE `personal_number` = @personalCode", this.getConnection());
            command.Parameters.Add("@personalCode", MySqlDbType.UInt32).Value = id;
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

        public DataTable getPretifyDepartments()
        {
            this.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT department_code as №, name as Имя, phone as Телефон FROM `department`", this.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table;
        }

        public DataTable getPositionsByDepartmentCode(UInt32 code)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT position_id, id  FROM `deppos` WHERE `department_code` = @uCode", this.getConnection());
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
            MySqlCommand command = new MySqlCommand("SELECT name, salary FROM `position` WHERE `position_code` = @uCode", this.getConnection());
            command.Parameters.Add("@uCode", MySqlDbType.VarChar).Value = code;
            this.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table;
        }

        public DataTable getPositionCodeByData(string name, int salary)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT position_code FROM `position` WHERE `name` = @uName AND `salary` = @uSalary", this.getConnection());
            command.Parameters.Add("@uName", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@uSalary", MySqlDbType.Int32).Value = salary;
            this.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table;
        }

        public void addDepartment(string name, string phone)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `department` " +
                "(`name`, `phone`)" +
                "VALUES (@name, @phone);", this.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;


            this.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Добавлено успешно");
            }
            else
            {
                MessageBox.Show("Что-то пошло не так");
            }
            this.closeConnection();
        }

        public void addPosition(string name, int salary)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `position` " +
                "(`name`, `salary`)" +
                "VALUES (@name, @salary);", this.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@salary", MySqlDbType.Int32).Value = salary;
           

            this.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
               
            }
            else
            {
                MessageBox.Show("Что-то пошло не так");
            }
            this.closeConnection();
        }

        public void addDepPos(uint departmentId, uint positionId)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `deppos` " +
                "(`department_code`, `position_id`)" +
                "VALUES (@departmentId, @positionId);", this.getConnection());

            command.Parameters.Add("@departmentId", MySqlDbType.UInt32).Value = departmentId;
            command.Parameters.Add("@positionId", MySqlDbType.UInt32).Value = positionId;


            this.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
               
            }
            else
            {
                MessageBox.Show("Что-то пошло не так");
            }
            this.closeConnection();
        }


        public void deleteAllDepPosByDepartmentCode(string code)
        {
            MySqlCommand command = new MySqlCommand("DELETE from `deppos` WHERE `department_code` = @ul", this.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = code;
            this.openConnection();
            command.ExecuteNonQuery();
            this.closeConnection();
        }

        public void deleteDepartmentByDepartmentCode(string code)
        {
            MySqlCommand command = new MySqlCommand("DELETE from `department` WHERE `department_code` = @ul", this.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = code;
            this.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Удалено успешно");
            }
            else
            {
                MessageBox.Show("Что-то пошло не так");
            }
            this.closeConnection();
        }

        public void deleteAllDepPosByPositionCode(uint code)
        {
            MySqlCommand command = new MySqlCommand("DELETE from `deppos` WHERE `position_id` = @ul", this.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.UInt32).Value = code;
            this.openConnection();
            command.ExecuteNonQuery();
            this.closeConnection();
        }

        public void deletePositionByCode(uint code)
        {
            MySqlCommand command = new MySqlCommand("DELETE from `position` WHERE `position_code` = @ul", this.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.UInt32).Value = code;
            this.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Удалено успешно");
            }
            else
            {
                MessageBox.Show("Что-то пошло не так");
            }
            this.closeConnection();
        }

        public void updateDepartment(uint code, string name, string phone)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `department` SET `name` = @name, `phone` = @phone WHERE `department_code` = @code", this.getConnection());
            
            command.Parameters.Add("@name", MySqlDbType.String).Value = name;
            command.Parameters.Add("@phone", MySqlDbType.String).Value = phone;
            command.Parameters.Add("@code", MySqlDbType.UInt32).Value = code;
            this.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                
            }
            else
            {
                MessageBox.Show("Что-то пошло не так");
            }
            this.closeConnection();
        }

        public DataTable getEmployeesForReport()
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
    }
}
