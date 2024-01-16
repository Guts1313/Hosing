using DataAccessLayer;
using DataAccessLayer.Interfaces;
using DataItems.LogicItems;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DAL
{
    public class DALEmployeeController : SQLConnectParent, IEmployeeController
    {
        public bool Create(Employee employee, byte[] key, byte[] iv)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "INSERT INTO Employee (Username, Password, DepartmentID, Name, Email, Phone, Shifts, ProfilePicture, Salary, HireDate, SalaryKey, SalaryIv) VALUES (@username, @password, @departmentID, @name, @email, @phone, @shifts, @profilepicture, @salary, @hiredate, @salaryKey, @salaryIv)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", employee.Username);
                        cmd.Parameters.AddWithValue("@password", employee.Password);
                        cmd.Parameters.AddWithValue("@departmentID", employee.Department.Id);
                        cmd.Parameters.AddWithValue("@name", employee.Name);
                        cmd.Parameters.AddWithValue("@email", employee.Email);
                        cmd.Parameters.AddWithValue("@phone", employee.Phone);
                        cmd.Parameters.AddWithValue("@shifts", employee.Shifts);
                        cmd.Parameters.AddWithValue("@profilepicture", "https://upload.wikimedia.org/wikipedia/commons/2/2c/Default_pfp.svg");
                        cmd.Parameters.AddWithValue("@salary", employee.Salary);
                        cmd.Parameters.AddWithValue("@hiredate", employee.HireDate);
                        cmd.Parameters.AddWithValue("@salaryKey", key);
                        cmd.Parameters.AddWithValue("@salaryIv", iv);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0) return false;
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Create(Employee employee, byte[] key, byte[] iv,byte[]bsnKey,byte[]bsnIv)
        {
              using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "INSERT INTO Employee (Username, Password, DepartmentID, Name, Email, Phone, Shifts, ProfilePicture, Salary, HireDate, SalaryKey, SalaryIv,BSN,BSN_Key,BSN_Iv) VALUES (@username, @password, @departmentID, @name, @email, @phone, @shifts, @profilepicture, @salary, @hiredate, @salaryKey, @salaryIv,@bsn,@bsn_key,@bsn_iv)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", employee.Username);
                        cmd.Parameters.AddWithValue("@password", employee.Password);
                        cmd.Parameters.AddWithValue("@departmentID", employee.Department.Id);
                        cmd.Parameters.AddWithValue("@name", employee.Name);
                        cmd.Parameters.AddWithValue("@email", employee.Email);
                        cmd.Parameters.AddWithValue("@phone", employee.Phone);
                        cmd.Parameters.AddWithValue("@shifts", employee.Shifts);
                        cmd.Parameters.AddWithValue("@profilepicture", "https://upload.wikimedia.org/wikipedia/commons/2/2c/Default_pfp.svg");
                        cmd.Parameters.AddWithValue("@salary", employee.Salary);
                        cmd.Parameters.AddWithValue("@hiredate", employee.HireDate);
                        cmd.Parameters.AddWithValue("@salaryKey", key);
                        cmd.Parameters.AddWithValue("@salaryIv", iv);
                        cmd.Parameters.AddWithValue("@bsn", employee.BSN);
                        cmd.Parameters.AddWithValue("@bsn_key", bsnKey);
                        cmd.Parameters.AddWithValue("@bsn_iv", bsnIv);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0) return false;
                    }

                }
                return true;
            
        }

        public bool Delete(Employee employee)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "DELETE FROM Employee WHERE Id = @id;" +
                                 "DELETE FROM Shift WHERE EmployeeId = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", employee.Id);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0) return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Employee[] GetAll()
        {
            try
            {
                List<Employee> employees = new();
                DALDepartmentController _departmentController = new DALDepartmentController();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Employee";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            Department department = _departmentController.Get(Convert.ToInt32(dr[3]));
                            if (department.Id > 2)
                                employees.Add(new Employee(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), department, dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), (byte[])dr[7], Convert.ToDateTime(dr[8]), dr[9].ToString(), Convert.ToInt32(dr[10])));
                            else
                                employees.Add(new Employee(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), department));
                        }
                    }

                }
                return employees.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Employee GetByUsername(string username)
        {
            try
            {
                Employee employee = null;
                DALDepartmentController _departmentController = new DALDepartmentController();

                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Employee WHERE Username = @username";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            Department department = _departmentController.Get(Convert.ToInt32(dr["DepartmentId"]));
                            employee = new Employee(Convert.ToInt32(dr["Id"]),
                                dr["Username"].ToString(),
                                dr["Password"].ToString(),
                                department,
                                dr["Name"].ToString(),
                                dr["Email"].ToString(),
                                dr["Phone"].ToString(),
                                (byte[])(dr["Salary"]),
                                Convert.ToDateTime(dr["HireDate"]),
                                dr["ProfilePicture"].ToString(),
                                Convert.ToInt32(dr["Shifts"]));
                        }
                    }
                }
                return employee;
            }
            catch (Exception ex)
            {
                // Optionally log the exception or handle it as necessary
                return null;
            }
        }


        public Employee GetById(int id)
        {
            try
            {
                Employee employee = null;
                DALDepartmentController _departmentController = new DALDepartmentController();

                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Employee WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            Department department = _departmentController.Get(Convert.ToInt32(dr[3]));
                            employee = new Employee(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), department, dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), (byte[])(dr[7]), Convert.ToDateTime(dr[8]), dr[9].ToString(), Convert.ToInt32(dr[10]));
                        }
                    }

                }
                return employee;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DateTime? GetClosestShiftDate(int employeeId)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                conn.Open();
                string sql = "SELECT TOP 1 Date FROM Shift WHERE EmployeeId = @employeeId AND Date >= GETDATE() AND IsCancelled = 0 ORDER BY Date ASC";

                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@employeeId", employeeId);

                var result = cmd.ExecuteScalar();
                if (result != null && DateTime.TryParse(result.ToString(), out DateTime shiftDate))
                {
                    return shiftDate;
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception as necessary
            }

            return null; // Return null if no shifts found or an exception occurs
        }

        public bool Update(Employee employee, byte[] key, byte[] iv)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "UPDATE Employee SET Username = @username, Password = @password, DepartmentID = @departmentID, Name = @name, Email = @email, Phone = @phone, Shifts = @shifts, ProfilePicture = @profilepicture, Salary = @salary, HireDate = @hiredate, SalaryKey = @salaryKey, SalaryIv = @salaryIv WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", employee.Id);
                        cmd.Parameters.AddWithValue("@username", employee.Username);
                        cmd.Parameters.AddWithValue("@password", employee.Password);
                        cmd.Parameters.AddWithValue("@departmentID", employee.Department.Id);
                        cmd.Parameters.AddWithValue("@name", employee.Name);
                        cmd.Parameters.AddWithValue("@email", employee.Email);
                        cmd.Parameters.AddWithValue("@phone", employee.Phone);
                        cmd.Parameters.AddWithValue("@shifts", employee.Shifts);
                        cmd.Parameters.AddWithValue("@profilepicture", employee.ProfilePicture);
                        cmd.Parameters.AddWithValue("@salary", employee.Salary);
                        cmd.Parameters.AddWithValue("@hiredate", employee.HireDate);
                        cmd.Parameters.AddWithValue("@salaryKey", key);
                        cmd.Parameters.AddWithValue("@salaryIv", iv);
                        
                        
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0) return false;
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update(Employee employee,byte[] key, byte[] iv,byte[] bsnKey, byte[] bsnIv)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "UPDATE Employee SET Username = @username, Password = @password, DepartmentID = @departmentID, Name = @name, Email = @email, Phone = @phone, " +
                                 "Shifts = @shifts, ProfilePicture = @profilepicture, " +
                                 "Salary = @salary, HireDate = @hiredate, SalaryKey = @salaryKey, " +
                                 "SalaryIv = @salaryIv, BSN=@BSN, BSN_Key=@BSN_Key,BSN_Iv=@BSN_Iv WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", employee.Id);
                        cmd.Parameters.AddWithValue("@username", employee.Username);
                        cmd.Parameters.AddWithValue("@password", employee.Password);
                        cmd.Parameters.AddWithValue("@departmentID", employee.Department.Id);
                        cmd.Parameters.AddWithValue("@name", employee.Name);
                        cmd.Parameters.AddWithValue("@email", employee.Email);
                        cmd.Parameters.AddWithValue("@phone", employee.Phone);
                        cmd.Parameters.AddWithValue("@shifts", employee.Shifts);
                        cmd.Parameters.AddWithValue("@profilepicture", employee.ProfilePicture);
                        cmd.Parameters.AddWithValue("@salary", employee.Salary);
                        cmd.Parameters.AddWithValue("@hiredate", employee.HireDate);
                        cmd.Parameters.AddWithValue("@salaryKey", key);
                        cmd.Parameters.AddWithValue("@salaryIv", iv);
                        cmd.Parameters.AddWithValue("@BSN", employee.BSN);
                        cmd.Parameters.AddWithValue("@BSN_Key", bsnKey);
                        cmd.Parameters.AddWithValue("@BSN_Iv", bsnIv);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0) return false;
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public Employee[] GetAvailableEmployees(DateTime date, int shiftType)
        {
            try
            {
                List<Employee> employees = new();
                DALDepartmentController _departmentController = new DALDepartmentController();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM EMPLOYEE WHERE Id NOT IN" +
                        "(SELECT EmployeeId FROM Shift WHERE Date = @date AND ShiftType = @shiftType " +
                        "AND IsCancelled = 1) AND DepartmentID NOT IN (1, 2);";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@shiftType", shiftType);

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            Department department = _departmentController.Get(Convert.ToInt32(dr[3]));
                            if (department.Id > 2)
                                employees.Add(new Employee(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), department, dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), (byte[])(dr[7]), Convert.ToDateTime(dr[8]), dr[9].ToString(), Convert.ToInt32(dr[10])));
                            else
                                employees.Add(new Employee(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), department));
                        }
                    }

                }
                return employees.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool ChangePassword(string email, string newPassword)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "UPDATE [Employee] " +
                        "SET Password = @password " +
                        "WHERE Email = @email";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@password", newPassword);
                        cmd.Parameters.AddWithValue("@email", email);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0) return false;
                    }

                }
                return true;
            }
            catch (SqlNullValueException ex)
            {
                throw new SqlNullValueException("Error, reading null values :" + ex.ToString());
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("An operation is attempted that is not valid for the current state of the database connection. :" + ex.ToString());
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occured in the SQL Server database. : " + ex.ToString());
            }
            catch (TimeoutException ex)
            {
                throw new TimeoutException("Database operation takes too long to complete, and the timeout period is exceeded.  " + ex.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public bool FindEmail(string emailToSearch)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT COUNT(*) FROM [Employee] WHERE Email = @email";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", emailToSearch);

                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();
                        
                        if (count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }

                }
                return true;
            }
            catch (SqlNullValueException ex)
            {
                throw new SqlNullValueException("Error, reading null values :" + ex.ToString());
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("An operation is attempted that is not valid for the current state of the database connection. :" + ex.ToString());
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occured in the SQL Server database. : " + ex.ToString());
            }
            catch (TimeoutException ex)
            {
                throw new TimeoutException("Database operation takes too long to complete, and the timeout period is exceeded.  " + ex.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public byte[] GetKeyByIndex(int index)
        {
            byte[] key;
            try
            {
                key = default;
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Employee WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", index);

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            key = (byte[])dr[11];
                        }
                    }

                }
                return key;
            }
            catch (Exception ex)
            {
                return default;
            }
        }

        public byte[] GetIvByIndex(int index)
        {
            byte[] iv;
            try
            {
                iv = default;
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Employee WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", index);

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            iv = (byte[])dr[12];
                        }
                    }

                }
                return iv;
            }
            catch (Exception ex)
            {
                return default;
            }
        }

        public byte[] GetKeyByName(string name)
        {
            byte[] key;
            try
            {
                key = default;
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Employee WHERE Username = @name";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            key = (byte[])dr[11];
                        }
                    }

                }
                return key;
            }
            catch (Exception ex)
            {
                return default;
            }
        }

        public byte[] GetIvByName(string name)
        {
            byte[] iv;
            try
            {
                iv = default;
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Employee WHERE Username = @name";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            iv = (byte[])dr[12];
                        }
                    }

                }
                return iv;
            }
            catch (Exception ex)
            {
                return default;
            }
        }
    }
}
