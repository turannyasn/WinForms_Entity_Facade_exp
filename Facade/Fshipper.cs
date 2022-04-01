using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Facade
{
   public  class Fshipper
    {

        public static  bool Insert(Eshipper shipper)
        {
            bool sonuc;
            SqlConnection conn = new SqlConnection(Connection.GetConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "pr_insert";
            SqlParameter[] param = {
                            new  SqlParameter{ParameterName="CompanyName",Value=shipper.CompanyName },
                            new  SqlParameter{ParameterName="Phone",Value=shipper.Phone },
            };

            cmd.Parameters.AddRange(param);
           
            
            try
            {
                if (conn.State!=System.Data.ConnectionState.Open)
                {
                    conn.Open();
                  
                }
                sonuc = cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch 
            {

                sonuc=false;
            }

            finally
            {
                if (conn.State!=System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return sonuc;
        }

        public static bool update(Eshipper shipper)
        {
            if (shipper==null)
            {
                return false;
            }
            if (shipper.ShipperID<0 || string.IsNullOrEmpty(shipper.CompanyName.ToString()))
            {
                return false;
            }

            bool sonuc;
            SqlConnection conn = new SqlConnection(Connection.GetConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "pr_update";
            SqlParameter[] param = {
                            new  SqlParameter{ParameterName="ShipperID",Value=shipper.ShipperID },
                            new  SqlParameter{ParameterName="CompanyName",Value=shipper.CompanyName },
                            new  SqlParameter{ParameterName="Phone",Value=shipper.Phone },
            };

            cmd.Parameters.AddRange(param);


            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();

                }
                sonuc = cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch
            {

                sonuc = false;
            }

            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return sonuc;

        }

        public static bool del(int ShipperID)
        {
           
            if (ShipperID <= 0 )
            {
                return false;
            }

            bool sonuc;
            SqlConnection conn = new SqlConnection(Connection.GetConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "pr_del";
            SqlParameter param = 
                            new  SqlParameter{ParameterName="ShipperID",Value=ShipperID 
                            
            };

            cmd.Parameters.Add(param);


            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();

                }
                sonuc = cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch
            {

                sonuc = false;
            }

            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return sonuc;

        }
    }
}
