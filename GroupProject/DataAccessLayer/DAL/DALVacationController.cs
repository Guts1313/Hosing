using ClassLibrary.Interfaces;
using System.Data.SqlClient;
using BussinessLayer.Classes;
namespace DataAccessLayer.DAL
{
    public class DALVacationController : SQLConnectParent, IVacationController
    {
        public bool Create(Vacation vacation)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "INSERT INTO Vacation (EmployeeId, StartDate, EndDate, Reason, Approved, Pending) VALUES (@employeeId, @startDate, @endDate, @reason, @approved, @pending)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", vacation.Employee.Id);
                        cmd.Parameters.AddWithValue("@startDate", vacation.StartDate.ToDateTime(TimeOnly.MinValue));
                        cmd.Parameters.AddWithValue("@endDate", vacation.EndDate.ToDateTime(TimeOnly.MinValue));
                        cmd.Parameters.AddWithValue("@reason", vacation.Reason);
                        cmd.Parameters.AddWithValue("@approved", vacation.Approved);
                        cmd.Parameters.AddWithValue("@pending", vacation.Pending);

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

        public Vacation[] ReadAll()
        {
            try
            {
                List<Vacation> vacations = new();
                EmployeeController _employeeController = new(new DALEmployeeController());


                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Vacation ORDER BY StartDate";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            int id = Convert.ToInt32(dr[0]);
                            Employee employee = _employeeController.GetById(Convert.ToInt32(dr[1]));
                            DateOnly startDate = DateOnly.FromDateTime(Convert.ToDateTime(dr[2]));
                            DateOnly endDate = DateOnly.FromDateTime(Convert.ToDateTime(dr[3]));
                            string reason = dr[4].ToString();
                            bool approved = Convert.ToBoolean(dr[5]);
                            bool pending = Convert.ToBoolean(dr[6]);

                            Vacation vacation = new(id, employee, startDate, endDate, reason, approved, pending);

                            vacations.Add(vacation);
                        }
                    }

                }
                return vacations.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Vacation[] ReadAllByMember(int employeeId)
        {
            try
            {
                List<Vacation> vacations = new();
                EmployeeController _employeeController = new(new DALEmployeeController());


                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Vacation WHERE EmployeeId = @employeeId ORDER BY StartDate";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", employeeId);

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            int id = Convert.ToInt32(dr[0]);
                            Employee employee = _employeeController.GetById(Convert.ToInt32(dr[1]));
                            DateOnly startDate = DateOnly.FromDateTime(Convert.ToDateTime(dr[2]));
                            DateOnly endDate = DateOnly.FromDateTime(Convert.ToDateTime(dr[3]));
                            string reason = dr[4].ToString();
                            bool approved = Convert.ToBoolean(dr[5]);
                            bool pending = Convert.ToBoolean(dr[6]);

                            Vacation vacation = new(id, employee, startDate, endDate, reason, approved, pending);

                            vacations.Add(vacation);
                        }
                    }

                }
                return vacations.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Vacation[] ReadAllByMemberFiltered(string filter, int employeeId)
        {
            try
            {
                List<Vacation> vacations = new();
                EmployeeController _employeeController = new(new DALEmployeeController());


                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = filter;

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", employeeId);

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            int id = Convert.ToInt32(dr[0]);
                            Employee employee = _employeeController.GetById(Convert.ToInt32(dr[1]));
                            DateOnly startDate = DateOnly.FromDateTime(Convert.ToDateTime(dr[2]));
                            DateOnly endDate = DateOnly.FromDateTime(Convert.ToDateTime(dr[3]));
                            string reason = dr[4].ToString();
                            bool approved = Convert.ToBoolean(dr[5]);
                            bool pending = Convert.ToBoolean(dr[6]);

                            Vacation vacation = new(id, employee, startDate, endDate, reason, approved, pending);

                            vacations.Add(vacation);
                        }
                    }

                }
                return vacations.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Vacation ReadById(int id)
        {
            try
            {
                Vacation vacation = null;
                EmployeeController _employeeController = new(new DALEmployeeController());

                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Vacation WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            int vacationId = Convert.ToInt32(dr[0]);
                            Employee employee = _employeeController.GetById(Convert.ToInt32(dr[1]));
                            DateOnly startDate = DateOnly.FromDateTime(Convert.ToDateTime(dr[2]));
                            DateOnly endDate = DateOnly.FromDateTime(Convert.ToDateTime(dr[3]));
                            string reason = dr[4].ToString();
                            bool approved = Convert.ToBoolean(dr[5]);
                            bool pending = Convert.ToBoolean(dr[6]);

                            vacation = new(vacationId, employee, startDate, endDate, reason, approved, pending);

                        }
                    }

                }
                return vacation;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Update(Vacation vacation)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "UPDATE Vacation SET StartDate = @startDate, EndDate = @endDate, Reason = @reason, Approved = @approved, Pending = @pending WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", vacation.Id);
                        cmd.Parameters.AddWithValue("@startDate", vacation.StartDate.ToDateTime(TimeOnly.MinValue));
                        cmd.Parameters.AddWithValue("@endDate", vacation.EndDate.ToDateTime(TimeOnly.MinValue));
                        cmd.Parameters.AddWithValue("@reason", vacation.Reason);
                        cmd.Parameters.AddWithValue("@approved", vacation.Approved);
                        cmd.Parameters.AddWithValue("@pending", vacation.Pending);

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

        public bool Delete(Vacation vacation)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "DELETE FROM Vacation WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", vacation.Id);

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

    }
}
