using DataAccessLayer.IdataInterfaces;
using DataBlocks.LogicItems;
using System.Data.SqlClient;

namespace DataAccessLayer.DAL
{
    public class DALStockController : SQLConnectParent, IStockController
    {
        public bool Create(Stock stock)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "INSERT INTO Stock (Id, Name, Price, Amount, Description) VALUES (@id, @name, @price, @amount, @description)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", stock.Id);
                        cmd.Parameters.AddWithValue("@name", stock.Name);
                        cmd.Parameters.AddWithValue("@price", stock.Price);
                        cmd.Parameters.AddWithValue("@amount", stock.Amount);
                        cmd.Parameters.AddWithValue("@Description", stock.Description);

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

        public bool Delete(Stock stock)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "DELETE FROM Stock WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", stock.Id);

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

        public Stock[] GetAll()
        {
            try
            {
                List<Stock> stocks = new();

                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Stock";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {

                            Stock newShift = new Stock(Convert.ToInt32(dr[0]), dr[1].ToString(), Convert.ToDecimal(dr[2]), Convert.ToInt32(dr[3]), dr[4].ToString());

                            stocks.Add(newShift);
                            
                        }
                    }

                }
                return stocks.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Stock GetById(int id)
        {
            try
            {
                Stock stock;
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Stock Where Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            stock = new Stock(Convert.ToInt32(dr[0]), dr[1].ToString(), Convert.ToDecimal(dr[2]), Convert.ToInt32(dr[3]), dr[4].ToString());
                            return stock;
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

        public bool Update(Stock stock)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "UPDATE Stock SET Id = @id, Name = @name, Price = @price, Amount = @amount, Description = @description " + "WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", stock.Id);
                        cmd.Parameters.AddWithValue("@name", stock.Name);
                        cmd.Parameters.AddWithValue("@price", stock.Price);
                        cmd.Parameters.AddWithValue("@amount", stock.Amount);
                        cmd.Parameters.AddWithValue("@description", stock.Description);

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

        public bool UpdateStockAmount(Stock stock)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "UPDATE Stock SET Amount = @amount " + 
                                "WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", stock.Id);
                        cmd.Parameters.AddWithValue("@amount", stock.Amount);

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
