using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataItems.LogicItems;
using DataAccessLayer.Interfaces;

namespace DataAccessLayer.DAL
{
    public class DALDepartmentController : SQLConnectParent, IDepartmentController
    {
        public bool Create(Department department)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "INSERT INTO Department (Name) VALUES (@name)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", department.Name);
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

        public bool Delete(Department department)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "DELETE FROM Department WHERE Name = @name";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", department.Name);

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

        public Department[] GetAll()
        {
            try
            {
                List<Department> departments = new();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Department";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            departments.Add(new Department(Convert.ToInt32(dr[0]), dr[1].ToString()));
                        }
                    }

                }
                return departments.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Department Get(int id)
        {
            foreach (Department department in GetAll())
            {
                if (department.Id == id) return department;
            }
            return null;
        }

        public Department Get(string name)
        {
            foreach (Department department in GetAll())
            {
                if (department.Name == name) return department;
            }
            return null;
        }

        public bool Update(Department department)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "UPDATE Department SET Name = @name WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", department.Name);
                        cmd.Parameters.AddWithValue("@id", department.Id);
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

