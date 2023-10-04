using ClassLibrary.Classes;
using System.Data.SqlClient;
using ClassLibrary.Interfaces;
using ClassLibrary.Controllers;
using System.Data;

namespace DataAccessLayer.DAL
{
    public class DALAnnouncementsController : SQLConnectParent, IAnnouncementController
    {
        public bool Create(Announcements announcements)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "INSERT INTO Announcements (Details,Title,StartDate,EndDate,VacationId) VALUES (@details,@title,@startdate,@enddate,@vacationId)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@details", announcements.Details);
                        cmd.Parameters.AddWithValue("@title", announcements.Title);
                        cmd.Parameters.AddWithValue("@startdate", announcements.StartDate.ToDateTime(TimeOnly.MinValue));
                        cmd.Parameters.AddWithValue("@enddate", announcements.EndDate.ToDateTime(TimeOnly.MinValue));
                        if (announcements.VacationId == 0)
                        {
                            cmd.Parameters.AddWithValue("@vacationId", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@vacationId", announcements.VacationId);
                        }
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        if (result < 0)
                            return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(Announcements announcements)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "DELETE FROM Announcements WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", announcements.Id);

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

        public Announcements[] GetAll()
        {
            try
            {
                List<Announcements> announcements = new();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                string sql = "SELECT * FROM Announcements";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DateOnly startDate = DateOnly.FromDateTime(Convert.ToDateTime(reader[3]));
                        DateOnly endDate = DateOnly.FromDateTime(Convert.ToDateTime(reader[4]));
                        int vacationId;
                        if (reader[5] != DBNull.Value)
                        {
                            vacationId = reader.GetInt32("VacationId");
                        }
                        else
                        {
                            vacationId = 0;
                        }

                        announcements.Add(new Announcements
                        {
                            Id = reader.GetInt32("Id"),
                            Details = reader.GetString("Details"),
                            Title = reader.GetString("Title"),
                            StartDate = startDate,
                            EndDate = endDate,
                            VacationId = vacationId
                        });
                    }
                }
                return announcements.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Announcements GetById(int id)
        {
            try
            {
                Announcements announcements = null;
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Announcements WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            DateOnly startDate = DateOnly.FromDateTime(Convert.ToDateTime(reader[3]));
                            DateOnly endDate = DateOnly.FromDateTime(Convert.ToDateTime(reader[4]));
                            int vacationId;
                            if (reader.GetInt32("VacationId") > 0)
                            {
                                vacationId = reader.GetInt32("VacationId");
                            }
                            else
                            {
                                vacationId = 0;
                            }

                            announcements = new Announcements
                            {
                                Id = reader.GetInt32("Id"),
                                Details = reader.GetString("Details"),
                                Title = reader.GetString("Title"),
                                StartDate = startDate,
                                EndDate = endDate,
                                VacationId = vacationId
                            };
                        }
                    }
                }
                return announcements;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Update(Announcements announcements)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                string sql = "UPDATE Announcements SET Details = @details, Title = @title, StartDate = @startdate, EndDate = @enddate WHERE Id = @id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", announcements.Id);
                    cmd.Parameters.AddWithValue("@details", announcements.Details);
                    cmd.Parameters.AddWithValue("@title", announcements.Title);
                    cmd.Parameters.AddWithValue("@startdate", announcements.StartDate.ToDateTime(TimeOnly.MinValue));
                    cmd.Parameters.AddWithValue("@enddate", announcements.EndDate.ToDateTime(TimeOnly.MinValue));
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result < 0)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Announcements[] GetAllCurrent()
        {
            try
            {
                List<Announcements> announcements = new();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                string sql = "SELECT * FROM Announcements WHERE StartDate <= @daysBefore AND EndDate >= @today";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@daysBefore", DateTime.Now.AddDays(3));
                    cmd.Parameters.AddWithValue("@today", DateTime.Now);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DateOnly startDate = DateOnly.FromDateTime(Convert.ToDateTime(reader[3]));
                        DateOnly endDate = DateOnly.FromDateTime(Convert.ToDateTime(reader[4]));
                        int vacationId;
                        if (reader.GetInt32("VacationId") > 0)
                        {
                            vacationId = reader.GetInt32("VacationId");
                        }
                        else
                        {
                            vacationId = 0;
                        }

                        announcements.Add(new Announcements
                        {
                            Id = reader.GetInt32("Id"),
                            Details = reader.GetString("Details"),
                            Title = reader.GetString("Title"),
                            StartDate = startDate,
                            EndDate = endDate,
                            VacationId = vacationId
                        });
                    }
                }
                return announcements.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }

}

