using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using StaffApp.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffApp
{
    public class DB
    {
        public static DataRow currentEmployee;
        public static DataRow chosenEmployeeAlreadyWorked;
        public static string access;
        public static Boolean isLogged = false;
        public static ServerData server = File.Exists("serviceData.json") ?
                JsonConvert.DeserializeObject<ServerData>(File.ReadAllText("serviceData.json")) :
                new ServerData
                {
                    host = "",
                    port = "",
                    user = "",
                    pass = "",
                    adminLogin = "admin",
                    adminPassword = "admin"
                };


        //server=localhost;port=3306;username=root;password=root;database=is-staff

        private MySqlConnection connection;
        public void setConnectionData()
        {
            connection = new MySqlConnection("server=" +server.host+";port=" +
                ""+server.port+";username="+server.user+";password=" +
                ""+server.pass+";database=is-staff");
        }
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
        public string convertBoolToStr(bool flag)
        {
            return flag ? "1" : "0";
        }

        public static bool IsEmpty(DataRow row)
        {
            return row == null || row.ItemArray.All(i => IsNullEquivalent(i));
        }

        public static bool IsNullEquivalent(object value)
        {
            return value == null
                   || value is DBNull
                   || string.IsNullOrWhiteSpace(value.ToString());
        }

        public DataTable getEmployees(Boolean isHidden)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT " +
                "e.personal_number AS '№', " +
                "e.name AS 'Имя', " +
                "e.surname AS 'Фамилия', " +
                "p.name AS 'Должность', " +
                "d.name as 'Отдел' " +
                "FROM `employee` e " +
                "JOIN position p ON e.position_code = p.position_code " +
                "JOIN department d ON e.department_code = d.department_code " +
                "WHERE e.hidden = "+isHidden, this.getConnection());
            this.openConnection();
            
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table;
        }


        public DataTable getEmployeesShort(bool isHidden = false)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT " +
                "e.personal_number AS '№', " +
                "e.name AS 'Имя', " +
                "e.surname AS 'Фамилия', " +
                "e.access AS 'Уровень доступа' " +
                "FROM `employee` e WHERE e.hidden = "+convertBoolToStr(isHidden), this.getConnection());
            this.openConnection();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table;
        }

        public DataTable getEmployeesByPosition(uint positionCode, Boolean isHidden = false)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT " +
                "e.personal_number AS '№', " +
                "e.name AS 'Имя', " +
                "e.surname AS 'Фамилия', " +
                "d.name as 'Отдел' " +
                "FROM `employee` e " +
                "JOIN department d ON e.department_code = d.department_code " +
                "WHERE e.hidden = @hidden AND e.position_code = @code" , this.getConnection());
            this.openConnection();
            command.Parameters.Add("@hidden", MySqlDbType.VarChar).Value = convertBoolToStr(isHidden);
            command.Parameters.Add("@code", MySqlDbType.VarChar).Value = positionCode;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table;
        }

        public void addEmployee(string name, string surname, string patronymic, string sex, 
            string family, string education, 
            int seniority, int deppos_code, 
            uint department_code, int position_code,
            string series, string number, DateTime date, 
            string body, string address, string access,
            string password,
            bool isHidden = false
            )
        {

            string sqlFormattedDate = date.Date.ToString("yyyy-MM-dd HH:mm:ss");

            MySqlCommand command = new MySqlCommand("INSERT INTO `employee` " +
                "(`name`, `surname`, `patronymic`, `sex`, " +
                "`family_status`, `education`, `seniority`, `autorization_pass`, `deppos_id`, `department_code`, `position_code`, " +
                "pass_series, pass_num, pass_body, reg_address, pass_date, access, hidden) " +
                "VALUES (@name, @surname, @patronymic, @sex, @family_status, @education, " +
                "@seniority, @password, @deppos_id, @department_code, @position_code, " +
                "@series, @number, @body, @address, @date, @access, @hidden)", this.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname;
            command.Parameters.Add("@patronymic", MySqlDbType.VarChar).Value = patronymic;
            command.Parameters.Add("@sex", MySqlDbType.VarChar).Value = sex;
            command.Parameters.Add("@family_status", MySqlDbType.VarChar).Value = family;
            command.Parameters.Add("@education", MySqlDbType.VarChar).Value = education;
            command.Parameters.Add("@seniority", MySqlDbType.VarChar).Value = seniority;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@deppos_id", MySqlDbType.VarChar).Value = deppos_code;
            command.Parameters.Add("@department_code", MySqlDbType.VarChar).Value = department_code;
            command.Parameters.Add("@position_code", MySqlDbType.VarChar).Value = position_code;

            command.Parameters.Add("@series", MySqlDbType.VarChar).Value = series;
            command.Parameters.Add("@number", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@body", MySqlDbType.VarChar).Value = body;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = sqlFormattedDate;

            command.Parameters.Add("@access", MySqlDbType.VarChar).Value = access;
            command.Parameters.Add("@hidden", MySqlDbType.VarChar).Value = convertBoolToStr(isHidden);

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

        public DataTable getEmployeeInfo(int id)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `employee` WHERE `personal_number` = @personalCode", this.getConnection());
            command.Parameters.Add("@personalCode", MySqlDbType.Int32).Value = id;
            this.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table;
        }

        public DataTable getEmployeeIdByInfo(
            string name,
            string surname,
            string series,
            string number
            )
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT personal_number FROM `employee` WHERE `name` = @name AND " +
                "`surname` = @surname AND `pass_series` = @series AND `pass_num` = @number", this.getConnection());
            command.Parameters.Add("@name", MySqlDbType.Text).Value = name;
            command.Parameters.Add("@surname", MySqlDbType.Text).Value = surname;
            command.Parameters.Add("@series", MySqlDbType.Text).Value = series;
            command.Parameters.Add("@number", MySqlDbType.Text).Value = number;

            this.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table;
        }

        public DataTable getEmployeeFullInfo(
            int persNumber
            )
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT e.personal_number, e.name, e.surname, e.patronymic, " +
                "e.sex, e.family_status, e.education, e.seniority, e.autorization_pass, e.deppos_id, " +
                "e.position_code, e.department_code, e.pass_series,e.pass_num,e.pass_body,e.reg_address," +
                "e.pass_date,e.access,d.name as 'department_name',d.phone as 'department_phone',p.name " +
                "as 'position_name',p.salary as 'position_salary'FROM employee e JOIN position p ON e.position_code = " +
                "p.position_code JOIN department d ON e.department_code = d.department_code WHERE e.personal_number = " +
                "@uL", this.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = persNumber;
            this.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table;
        }

        public DataTable getDepartments(bool isHidden = false)
        {
            this.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT department_code, name FROM `department` WHERE hidden = "+convertBoolToStr(isHidden), this.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table;
        }

        public DataTable getPretifyDepartments(bool isHidden = false)
        {
            this.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT department_code as №, name as Имя, phone as Телефон FROM `department` WHERE hidden = "+ convertBoolToStr(isHidden), this.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table;
        }

        public DataTable getDepartmenByName(string name)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT department_code FROM `department` WHERE `name` = @uName", this.getConnection());
            command.Parameters.Add("@uName", MySqlDbType.VarChar).Value = name;
            this.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table;
        }

        public DataTable getPositionsByDepartmentCode(UInt32 code, bool isHidden = false)
        {
            
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT d.id, p.position_code, " +
                "p.name, p.salary FROM deppos d JOIN position p " +
                "ON p.position_code = d.position_id WHERE " +
                "`department_code` = @uCode AND p.hidden = @hidden AND d.hidden = @hidden", this.getConnection());
            command.Parameters.Add("@uCode", MySqlDbType.VarChar).Value = code;
            command.Parameters.Add("@hidden", MySqlDbType.VarChar).Value = convertBoolToStr(isHidden);
            this.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table;
        }

        public DataTable getPositionByCode(uint code)
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

        public DataTable getDepartmentByCode(uint code)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT name FROM `department` WHERE `department_code` = @uCode", this.getConnection());
            command.Parameters.Add("@uCode", MySqlDbType.VarChar).Value = code;
            this.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table;
        }

        public DataTable getHiddenPositions()
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT p.name as position_name, p.salary, d.department_code, dep.name as department_name, dep.phone as department_phone FROM `position` p JOIN deppos d ON p.position_code = d.position_id JOIN department dep ON dep.department_code = d.department_code AND dep.hidden = 0 WHERE p.hidden = 1", this.getConnection());
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

        public void addDepartment(string name, string phone, bool isHidden = false)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `department` " +
                "(`name`, `phone`, `hidden`)" +
                "VALUES (@name, @phone, @hidden);", this.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@hidden", MySqlDbType.VarChar).Value = convertBoolToStr(isHidden);

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

        public void addPosition(string name, int salary, bool hidden = false)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `position` " +
                "(`name`, `salary`, `hidden`)" +
                "VALUES (@name, @salary, @hidden);", this.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@salary", MySqlDbType.Int32).Value = salary;
            command.Parameters.Add("@hidden", MySqlDbType.VarChar).Value = convertBoolToStr(hidden);
           

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

        public void addDepPos(uint departmentId, uint positionId, bool hidden = false)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `deppos` " +
                "(`department_code`, `position_id`, `hidden`)" +
                "VALUES (@departmentId, @positionId, @hidden);", this.getConnection());

            command.Parameters.Add("@departmentId", MySqlDbType.UInt32).Value = departmentId;
            command.Parameters.Add("@positionId", MySqlDbType.UInt32).Value = positionId;
            command.Parameters.Add("@hidden", MySqlDbType.VarChar).Value = convertBoolToStr(hidden);

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
            MySqlCommand command = new MySqlCommand("UPDATE `deppos` SET hidden = 1 WHERE `department_code` = @ul", this.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = code;
            this.openConnection();
            command.ExecuteNonQuery();
            this.closeConnection();
        }

        public void deleteDepartmentByDepartmentCode(string code)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `department` SET hidden = 1 WHERE `department_code` = @ul", this.getConnection());
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


        public void updateEmployee(
            int personalCode,
            string name,
            string surname,
            string patr,
            string sex,
            string family,
            string education,
            string seniority,
            uint departmentCode,
            int positionCode,
            int deppos_id,
            string series,
            string body,
            string number,
            string address,
            DateTime date
            )
        {

            string sqlFormattedDate = date.Date.ToString("yyyy-MM-dd HH:mm:ss");

            MySqlCommand command = new MySqlCommand("UPDATE employee " +
                "SET name = @name, surname = @surname, " +
                "patronymic = @patr, sex = @sex, " +
                "family_status = @family, education = @education, " +
                "seniority = @seniority, department_code = @departmentCode, " +
                "position_code = @positionCode, deppos_id = @deppos_id, pass_series = @series, " +
                "pass_body = @body, pass_num = @number, reg_address = @address, " +
                "pass_date = @date " +
                "WHERE personal_number = @code", this.getConnection());

            command.Parameters.Add("@name", MySqlDbType.String).Value = name;
            command.Parameters.Add("@surname", MySqlDbType.String).Value = surname;
            command.Parameters.Add("@patr", MySqlDbType.String).Value = patr;
            command.Parameters.Add("@sex", MySqlDbType.String).Value = sex;
            command.Parameters.Add("@family", MySqlDbType.String).Value = family;
            command.Parameters.Add("@education", MySqlDbType.String).Value = education;
            command.Parameters.Add("@seniority", MySqlDbType.String).Value = seniority;
            command.Parameters.Add("@departmentCode", MySqlDbType.UInt32).Value = departmentCode;
            command.Parameters.Add("@positionCode", MySqlDbType.UInt32).Value = positionCode;
            command.Parameters.Add("@deppos_id", MySqlDbType.UInt32).Value = deppos_id;

            command.Parameters.Add("@series", MySqlDbType.String).Value = series;
            command.Parameters.Add("@body", MySqlDbType.String).Value = body;
            command.Parameters.Add("@number", MySqlDbType.String).Value = number;
            command.Parameters.Add("@address", MySqlDbType.String).Value = address;
            command.Parameters.Add("@date", MySqlDbType.String).Value = sqlFormattedDate;

            command.Parameters.Add("@code", MySqlDbType.String).Value = personalCode;

            this.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Успешно обновлено!");
            }
            else
            {
                MessageBox.Show("Что-то пошло не так");
            }
            this.closeConnection();
        }


        public DataTable getDepPosByCodes(uint departmentCode, int positionCode)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT id FROM `deppos` WHERE `department_code` = @depCode AND `position_id` = @posCode", this.getConnection());
            command.Parameters.Add("@depCode", MySqlDbType.VarChar).Value = departmentCode;
            command.Parameters.Add("@posCode", MySqlDbType.VarChar).Value = positionCode;
            this.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table;
        }

        public void deleteAllDepPosByPositionCode(uint code)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `deppos` d SET d.hidden = 1 WHERE `position_id` = @ul", this.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.UInt32).Value = code;
            this.openConnection();
            command.ExecuteNonQuery();
            this.closeConnection();
        }

        public void deletePositionsByDepartmenCode(string code)
        {
            MySqlCommand command = new MySqlCommand("UPDATE position p JOIN deppos d ON p.position_code = d.position_id SET p.hidden = 1 WHERE d.department_code = @uCode", this.getConnection());
            command.Parameters.Add("@uCode", MySqlDbType.UInt32).Value = code;
            this.openConnection();
            command.ExecuteNonQuery();
            this.closeConnection();
        }

        public void deletePositionByCode(uint code)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `position` SET hidden = 1 WHERE `position_code` = @ul", this.getConnection());
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
            MySqlCommand command = new MySqlCommand("UPDATE department SET name = @name, phone = @phone WHERE department_code = @code", this.getConnection());
            
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

        public void updatePosition(uint code, string name, string salary)
        {
            MySqlCommand command = new MySqlCommand("UPDATE position " +
                "SET name = @name, salary = @salary WHERE " +
                "position_code = @code", this.getConnection());

            command.Parameters.Add("@name", MySqlDbType.String).Value = name;
            command.Parameters.Add("@salary", MySqlDbType.String).Value = salary;
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

        public void changePassword(string password)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `employee` SET `autorization_pass` = @pass WHERE `personal_number` = @pNum", this.getConnection());

            command.Parameters.Add("@pass", MySqlDbType.String).Value = password;
            command.Parameters.Add("@pNum", MySqlDbType.String).Value = DB.currentEmployee.Field<int>("personal_number");
            this.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Пароль успешно изменен!");
            }
            else
            {
                MessageBox.Show("Что-то пошло не так");
            }
            this.closeConnection();
        }

        public void updateAccess(string access, int personal_number)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `employee` SET `access` = @access WHERE `personal_number` = @pNum", this.getConnection());

            command.Parameters.Add("@access", MySqlDbType.String).Value = access;
            command.Parameters.Add("@pNum", MySqlDbType.String).Value = personal_number;
            this.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Уровень доступа был изменен!");
            }
            else
            {
                MessageBox.Show("Что-то пошло не так");
            }
            this.closeConnection();
        }
        public void clearAllData()
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM deppos", this.getConnection());
            MySqlCommand command2 = new MySqlCommand("DELETE FROM employee", this.getConnection());
            MySqlCommand command3 = new MySqlCommand("DELETE FROM position", this.getConnection());
            MySqlCommand command4 = new MySqlCommand("DELETE FROM department", this.getConnection());

            this.openConnection();

            if (command.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1 &&
                command3.ExecuteNonQuery() == 1 && command4.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("База полностью очищена!");
            }
            else
            {
                MessageBox.Show("Что-то пошло не так");
            }
            this.closeConnection();
        }

        public void removeUser(int personal_number, string fullName = "")
        {
            MySqlCommand command = new MySqlCommand("UPDATE `employee` SET hidden = 1 WHERE `personal_number` = @ul", this.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.Int32).Value = personal_number;

            this.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                if(fullName != "")
                    MessageBox.Show("Пользователь "+ fullName+", с табельным номером №"+personal_number+" успешно уволен!");
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
            MySqlCommand command = new MySqlCommand("SELECT e.personal_number, e.name, e.surname, e.patronymic, p.name as positionName, p.salary, d.name as departmentName, d.phone as departmentPhone FROM employee e INNER JOIN position p ON e.position_code = p.position_code JOIN department d ON e.department_code = d.department_code WHERE e.hidden = 0", this.getConnection());
            this.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table;
        }

        public int getEmployeesCountByDepartmentCode(uint departmentCode)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT department_code FROM employee WHERE department_code = @Code AND hidden = 0", this.getConnection());
            command.Parameters.Add("@Code", MySqlDbType.UInt32).Value = departmentCode;
            this.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table.Rows.Count;
        }

        public int getEmployeesCountByPositionCode(uint positionCode)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT position_code FROM employee WHERE position_code = @Code AND hidden = 0", this.getConnection());
            command.Parameters.Add("@Code", MySqlDbType.UInt32).Value = positionCode;
            this.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.closeConnection();
            return table.Rows.Count;
        }
    }
}
