using Entity;
using Facade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLShipper
    {
        public static bool BLL_Insert(Eshipper shipper)
        {
            bool sonuc;

            if (!string.IsNullOrEmpty(shipper.CompanyName) || !string.IsNullOrEmpty(shipper.Phone))
            {

                if (shipper.CompanyName.Length < 40 && shipper.Phone.Length < 24)
                {
                    sonuc = Fshipper.Insert(shipper);
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }

            
            return sonuc;
        }

        public static bool BLL_Update(Eshipper shipper)
        {
            bool sonuc;

            if (!string.IsNullOrEmpty(shipper.ShipperID.ToString()) ||!string.IsNullOrEmpty(shipper.CompanyName) || !string.IsNullOrEmpty(shipper.Phone))
            {

                if (shipper.CompanyName.Length < 40 && shipper.Phone.Length < 24)
                {
                    sonuc = Fshipper.update(shipper);
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }


            return sonuc;

        }
        public static bool BLL_del(int ShipperId)
        {
            bool sonuc;

            if (ShipperId>0)
            {

                sonuc=Fshipper.del(ShipperId);
               

            }
            else
            {
                return false;
            }


            return sonuc;
        }
        public static SqlDataReader doldur(Eshipper shipper)
        {
            SqlDataReader dr;
            dr=Fshipper.doldur(shipper);
            return dr; 
        }
    }
}
    
