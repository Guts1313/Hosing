using ClassLibrary.Classes;
using ClassLibrary.Interfaces;
using DataItems.LogicItems;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DAL
{
    public class DALCancelledShiftController : SQLConnectParent, ICancelledShiftController
    {
        public bool Create(CancelledShift cancelledShift)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "INSERT INTO CancelledShift (ShiftID, AssignedEmployeeID, NewEmployeeID, Reason, IsViewed) VALUES " +
                        "(@shiftId, @assignedEmployeeId, @newEmployeeId, @reason, @isViewed)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@shiftId", cancelledShift.Shift.Id);
                        cmd.Parameters.AddWithValue("@assignedEmployeeId", cancelledShift.Shift.Employee.Id);
                        if (cancelledShift.NewEmployee != null)
                        {
                            cmd.Parameters.AddWithValue("@newEmployeeId", cancelledShift.NewEmployee.Id);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@newEmployeeId", DBNull.Value);
                        }
                        cmd.Parameters.AddWithValue("@reason", cancelledShift.Reason);
                        cmd.Parameters.AddWithValue("@isViewed", cancelledShift.IsViewed);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0) { return false; }
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(CancelledShift cancelledShift)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "DELETE FROM CancelledShift WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", cancelledShift.Id);

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

        public CancelledShift[] GetAll()
        {
            try
            {
                List<CancelledShift> cancelledShifts = new();
                DALEmployeeController _employeeController = new DALEmployeeController();
                DALShiftController _shiftController = new DALShiftController();

                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT c.Id, c.ShiftID, c.AssignedEmployeeID, c.NewEmployeeID, c.Reason, c.IsViewed FROM CancelledShift AS c INNER JOIN Shift AS s ON c.ShiftID = s.Id ORDER BY s.Date";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        Shift shift;
                        Employee assignedEmployee;
                        Employee? newEmployee;

                        while (dr.Read())
                        {
                            shift = _shiftController.GetById(Convert.ToInt32(dr[1]));
                            assignedEmployee = _employeeController.GetById(Convert.ToInt32(dr[2]));
                            if (dr[3] is DBNull)
                            {
                                newEmployee = null;
                            }
                            else
                            {
                                newEmployee = _employeeController.GetById(Convert.ToInt32(dr[3]));
                            }

                            CancelledShift newCancelledShift = new CancelledShift(Convert.ToInt32(dr[0]), shift,
                                assignedEmployee, newEmployee, dr[4].ToString(), Convert.ToBoolean(dr[5]));

                            cancelledShifts.Add(newCancelledShift);
                        }
                    }

                }
                return cancelledShifts.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public CancelledShift[] GetAllAssigned(Employee employee) // is employee supposed to be for Assigned employee
                                                                  // or new Employee
        {
            try
            {
                List<CancelledShift> cancelledShifts = new();
                DALEmployeeController _employeeController = new DALEmployeeController();
                DALShiftController _shiftController = new DALShiftController();

                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT c.Id, c.ShiftID, c.AssignedEmployeeID, c.NewEmployeeID, c.Reason, c.IsViewed FROM CancelledShift AS c INNER JOIN Shift AS s ON c.ShiftID = s.Id WHERE c.AssignedEmployeeID = @id ORDER BY s.Date"; // I get cancelled shifts
                                                                                                                                                                                                                                            // for the old Employee

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", employee.Id);
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            Shift shift = _shiftController.GetById(Convert.ToInt32(dr[1]));
                            Employee assignedEmployee = _employeeController.GetById(Convert.ToInt32(dr[2]));
                            Employee? newEmployee;
                            if (dr[3] is DBNull)
                                newEmployee = null;
                            else
                                newEmployee = _employeeController.GetById(Convert.ToInt32(dr[3]));

                            CancelledShift newCancelledShift = new CancelledShift(Convert.ToInt32(dr[0]), shift,
                                assignedEmployee, newEmployee, dr[4].ToString(), Convert.ToBoolean(dr[5]));

                            cancelledShifts.Add(newCancelledShift);
                        }
                    }

                }
                return cancelledShifts.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public CancelledShift GetById(int id)
        {
            try
            {
                CancelledShift cancelledShift;
                DALEmployeeController _employeeController = new DALEmployeeController();
                DALShiftController _shiftController = new DALShiftController();

                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT c.Id, c.ShiftID, c.AssignedEmployeeID, c.NewEmployeeID, c.Reason, c.IsViewed FROM CancelledShift AS c INNER JOIN Shift AS s ON c.ShiftID = s.Id WHERE c.Id = @id ORDER BY s.Date";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            Shift shift = _shiftController.GetById(Convert.ToInt32(dr[1]));
                            Employee assignedEmployee = _employeeController.GetById(Convert.ToInt32(dr[2]));
                            Employee? newEmployee;
                            if (dr[3] is DBNull)
                                newEmployee = null;
                            else
                                newEmployee = _employeeController.GetById(Convert.ToInt32(dr[3]));

                            cancelledShift = new CancelledShift(Convert.ToInt32(dr[0]), shift,
                                assignedEmployee, newEmployee, dr[4].ToString(), Convert.ToBoolean(dr[5]));
                            return cancelledShift;
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

        public bool Update(CancelledShift cancelledShift)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "UPDATE CancelledShift SET ShiftID = @shiftId, AssignedEmployeeID = @assignedEmployeeId, " +
                        "NewEmployeeID = @newEmployeeId, Reason = @reason, IsViewed = @isViewed WHERE Id = @id";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", cancelledShift.Id);
                        cmd.Parameters.AddWithValue("@shiftId", cancelledShift.Shift.Id);
                        cmd.Parameters.AddWithValue("@assignedEmployeeId", cancelledShift.Shift.Employee.Id);
                        if (cancelledShift.NewEmployee != null)
                        {
                            cmd.Parameters.AddWithValue("@newEmployeeId", cancelledShift.NewEmployee.Id);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@newEmployeeId", DBNull.Value);
                        }
                        cmd.Parameters.AddWithValue("@reason", cancelledShift.Reason);
                        cmd.Parameters.AddWithValue("@isViewed", cancelledShift.IsViewed);

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

        public CancelledShift[] GetFromVacation(int id)
        {
            List<CancelledShift> cancelledShifts = new();
            try
            {
                DALEmployeeController _employeeController = new DALEmployeeController();
                DALVacationController _vacationController =new DALVacationController();
                DALShiftController _shiftController = new DALShiftController();

                Vacation vacation = _vacationController.ReadById(id);

                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT c.* " +
                        "FROM Shift " +
                        "AS s " +
                        "INNER JOIN CancelledShift AS c " +
                        "ON s.Id = c.ShiftID " +
                        "INNER JOIN Vacation AS v " +
                        "ON c.AssignedEmployeeID = v.EmployeeId " +
                        "WHERE c.AssignedEmployeeID = @empId " +
                        "AND c.NewEmployeeID IS NULL " +
                        "AND s.Date >= @startDate " +
						"AND s.Date <= @endDate " +
                        "ORDER BY s.Date";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@empId", vacation.Employee.Id);
                        cmd.Parameters.AddWithValue("@startDate", vacation.StartDate.ToDateTime(TimeOnly.MinValue));
                        cmd.Parameters.AddWithValue("@endDate", vacation.EndDate.ToDateTime(TimeOnly.MinValue));
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            Shift shift = _shiftController.GetById(Convert.ToInt32(dr[1]));
                            Employee assignedEmployee = _employeeController.GetById(Convert.ToInt32(dr[2]));
                            Employee? newEmployee;
                            if (dr[3] is DBNull)
                                newEmployee = null;
                            else
                                newEmployee = _employeeController.GetById(Convert.ToInt32(dr[3]));

                            CancelledShift newCancelledShift = new CancelledShift(Convert.ToInt32(dr[0]), shift,
                                assignedEmployee, newEmployee, dr[4].ToString(), Convert.ToBoolean(dr[5]));

                            cancelledShifts.Add(newCancelledShift);
                        }
                    }

                }
                return cancelledShifts.ToArray();
            }
            catch (Exception ex)
            {
                return cancelledShifts.ToArray();
            }
        }

        public CancelledShift[] GetAllInThePast()
        {
            try
            {
                List<CancelledShift> cancelledShifts = new();
                DALEmployeeController _employeeController = new DALEmployeeController();
                DALShiftController _shiftController = new DALShiftController();

                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT c.Id, c.ShiftID, c.AssignedEmployeeID, c.NewEmployeeID, c.Reason, c.IsViewed FROM CancelledShift AS c INNER JOIN Shift AS s ON c.ShiftID = s.Id WHERE s.Date < @date ORDER BY s.Date";


                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            Shift shift = _shiftController.GetById(Convert.ToInt32(dr[1]));
                            Employee assignedEmployee = _employeeController.GetById(Convert.ToInt32(dr[2]));
                            Employee? newEmployee;
                            if (dr[3] is DBNull)
                                newEmployee = null;
                            else
                                newEmployee = _employeeController.GetById(Convert.ToInt32(dr[3]));

                            CancelledShift newCancelledShift = new CancelledShift(Convert.ToInt32(dr[0]), shift,
                                assignedEmployee, newEmployee, dr[4].ToString(), Convert.ToBoolean(dr[5]));

                            cancelledShifts.Add(newCancelledShift);
                        }
                    }

                }
                return cancelledShifts.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public CancelledShift[] GetAllByStatus(bool status)
        {
            try
            {
                List<CancelledShift> cancelledShifts = new();
                DALEmployeeController _employeeController = new DALEmployeeController();
                DALShiftController _shiftController = new DALShiftController();

                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM CancelledShift WHERE IsViewed = @isViewed";
                    // for the old Employee

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@isViewed", status);
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            Shift shift = _shiftController.GetById(Convert.ToInt32(dr[1]));
                            Employee assignedEmployee = _employeeController.GetById(Convert.ToInt32(dr[2]));
                            Employee? newEmployee;
                            if (dr[3] is DBNull)
                                newEmployee = null;
                            else
                                newEmployee = _employeeController.GetById(Convert.ToInt32(dr[3]));

                            CancelledShift newCancelledShift = new CancelledShift(Convert.ToInt32(dr[0]), shift,
                                assignedEmployee, newEmployee, dr[4].ToString(), Convert.ToBoolean(dr[5]));

                            cancelledShifts.Add(newCancelledShift);
                        }
                    }

                }
                return cancelledShifts.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public CancelledShift[] GetAllIfNewEmpAssigned(bool assigned)
        {
            try
            {
                List<CancelledShift> cancelledShifts = new();
                DALEmployeeController _employeeController = new DALEmployeeController();
                DALShiftController _shiftController = new DALShiftController();

                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM CancelledShift WHERE NewEmployeeID IS ";
                    // for the old Employee
                    if (assigned)
                    {
                        sql += "NOT";
                    }
                    sql += " NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        //if (assigned)
                        //{
                        //	cmd.Parameters.AddWithValue("@newEmployeeId", "NOT");

                        //}
                        //else
                        //{
                        //                      cmd.Parameters.AddWithValue("@newEmployeeId", " ");
                        //                  }
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            Shift shift = _shiftController.GetById(Convert.ToInt32(dr[1]));
                            Employee assignedEmployee = _employeeController.GetById(Convert.ToInt32(dr[2]));
                            Employee? newEmployee;
                            if (dr[3] is DBNull)
                                newEmployee = null;
                            else
                                newEmployee = _employeeController.GetById(Convert.ToInt32(dr[3]));

                            CancelledShift newCancelledShift = new CancelledShift(Convert.ToInt32(dr[0]), shift,
                                assignedEmployee, newEmployee, dr[4].ToString(), Convert.ToBoolean(dr[5]));

                            cancelledShifts.Add(newCancelledShift);
                        }
                    }

                }
                return cancelledShifts.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
