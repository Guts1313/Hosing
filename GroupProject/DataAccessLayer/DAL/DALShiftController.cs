using DataAccessLayer.Interfaces;
using DataItems.LogicItems;
using System.Data.SqlClient;

namespace DataAccessLayer.DAL
{
    public class DALShiftController : SQLConnectParent, IShiftController
    {
        public bool Create(Shift shift)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "INSERT INTO Shift (EmployeeId, Date, ShiftType, IsCancelled) VALUES (@employeeid, @date, @shiftType, @isCancelled)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@employeeid", shift.Employee.Id);
                        cmd.Parameters.AddWithValue("@date", shift.Date);
                        cmd.Parameters.AddWithValue("@shiftType", shift.Type);
                        cmd.Parameters.AddWithValue("@isCancelled", 0);


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

        public bool Delete(Shift shift)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "DELETE FROM Shift WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", shift.Id);

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

        public Shift[] GetAll()
        {
            try
            {
                List<Shift> shifts = new();
                DALEmployeeController employeeController = new DALEmployeeController();

                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Shift";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {

                            Employee employee = employeeController.GetById(Convert.ToInt32(dr[1]));

                            Shift newShift = new Shift(Convert.ToInt32(dr[0]), employee, Convert.ToDateTime(dr[2]), Convert.ToInt32(dr[3]), Convert.ToBoolean(dr[4]));

                            if (!newShift.IsCancelled)
                            {
                                shifts.Add(newShift);
                            }
                        }
                    }

                }
                return shifts.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public Shift[] GetAllAssigned(Employee employee)
        {
            try
            {
                List<Shift> shifts = new();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Shift WHERE EmployeeId = @id AND IsCancelled = 0";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", employee.Id);
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            Shift newShift = new Shift(Convert.ToInt32(dr[0]), employee, Convert.ToDateTime(dr[2]), Convert.ToInt32(dr[3]), Convert.ToBoolean(dr[4]));

                            if (!newShift.IsCancelled)
                            {
                                shifts.Add(newShift);
                            }
                        }
                    }

                }
                return shifts.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Shift GetById(int id)
        {
            try
            {
                Shift shift;
                DALEmployeeController employeeController = new DALEmployeeController();

                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Shift Where Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            Employee employee = employeeController.GetById(Convert.ToInt32(dr[1]));
                            shift = new Shift(Convert.ToInt32(dr[0]), employee, Convert.ToDateTime(dr[2]), Convert.ToInt32(dr[3]), Convert.ToBoolean(dr[4]));
                            conn.Close();

                            return shift;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;
        }
        public Shift[] GetAllByDate(DateTime date)
        {
            try
            {
                List<Shift> shifts = new();
                DALEmployeeController employeeController = new DALEmployeeController();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Shift WHERE Date = @date";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", date);
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            Employee employee = employeeController.GetById(Convert.ToInt32(dr[1]));
                            Shift newShift = new Shift(Convert.ToInt32(dr[0]), employee, date, Convert.ToInt32(dr[3]), Convert.ToBoolean(dr[4]));

                            if (!newShift.IsCancelled)
                            {
                                shifts.Add(newShift);
                            }
                        }
                    }

                }
                conn.Close();

                return shifts.ToArray();
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        public bool Update(Shift shift)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "UPDATE Shift SET EmployeeId = @employeeId, Date = @date, ShiftType = @shiftType, IsCancelled = @isCancelled " + "WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", shift.Id);
                        cmd.Parameters.AddWithValue("@employeeid", shift.Employee.Id);
                        cmd.Parameters.AddWithValue("@date", shift.Date);
                        cmd.Parameters.AddWithValue("@shiftType", shift.Type);
                        cmd.Parameters.AddWithValue("@isCancelled", shift.IsCancelled);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0) return false;
                    }
                }
                conn.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public Shift[] GetFutureShiftsByEmp(Employee employee)
        {
            try
            {
                List<Shift> shifts = new();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Shift WHERE EmployeeId = @id AND Date >= @date AND IsCancelled = 0";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", employee.Id);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            Shift newShift = new Shift(Convert.ToInt32(dr[0]), employee, Convert.ToDateTime(dr[2]), Convert.ToInt32(dr[3]), Convert.ToBoolean(dr[4]));

                            if (!newShift.IsCancelled)
                            {
                                shifts.Add(newShift);
                            }
                        }
                    }

                }
                conn.Close();

                return shifts.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Shift[] GetShiftsFromVacation(Vacation vacation)
        {
            try
            {
                List<Shift> shifts = new();
                DALEmployeeController employeeController = new DALEmployeeController();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT s.* FROM Shift AS s INNER JOIN Vacation AS V ON s.EmployeeID = v.EmployeeId WHERE s.EmployeeID = @empId AND s.Date >= @startDate AND s.Date <= @endDate";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@empId", vacation.Employee.Id);
                        cmd.Parameters.AddWithValue("@startDate", vacation.StartDate.ToDateTime(TimeOnly.MinValue));
                        cmd.Parameters.AddWithValue("@endDate", vacation.EndDate.ToDateTime(TimeOnly.MinValue));

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            Employee employee = employeeController.GetById(Convert.ToInt32(dr[1]));
                            Shift newShift = new Shift(Convert.ToInt32(dr[0]), employee, Convert.ToDateTime(dr[2]), Convert.ToInt32(dr[3]), Convert.ToBoolean(dr[4]));

                            if (!newShift.IsCancelled)
                            {
                                shifts.Add(newShift);
                            }
                        }
                    }

                }
                conn.Close();
                return shifts.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<Employee> GetEmployeesByNameFragment(string nameFragment)
        {
            var employees = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                string query = "SELECT Id, Username, Password, DepartmentId FROM Employee WHERE Name LIKE @nameFragment";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameFragment", $"%{nameFragment}%");
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(reader.GetOrdinal("Id"));
                            string username = reader.GetString(reader.GetOrdinal("Username"));
                            string password = reader.GetString(reader.GetOrdinal("Password"));

                            int departmentId = reader.GetInt32(reader.GetOrdinal("Id"));
                            Department department = GetDepartmentById(departmentId);

                            var employee = new Employee(id, username, password, department);
                            employees.Add(employee);
                        }
                    }
                }
            }

            return employees;
        }

        private Department GetDepartmentById(int departmentId)
        {
            Department department = null;

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                string query = "SELECT Id, Name FROM Department WHERE Id = @departmentId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@departmentId", departmentId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = reader.GetInt32(reader.GetOrdinal("Id"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));

                            department = new Department(id, name);
                            conn.Close();
                        }
                    }
                }
            }

            return department;
        }
    }
}
