using QLTV.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caffe.DAL
{
    class DALQUANLY
    {
        public DataTable LoadBan()
        {
            SqlParameter[] p = { };
            DataTable dt = DB.ExecuteQuery("layBan", p);
            return dt;

        }

        public bool checkTenBan(string tenban)
        {
            try
            {
                SqlParameter[] p = {
            new SqlParameter("@tenban",SqlDbType.NVarChar,50)
            };
                p[0].Value = tenban;
                int rowsAffected = DB.ExecuteNonQuery("dbo.checkTenBan_", p);
                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }

        }


    }
}
