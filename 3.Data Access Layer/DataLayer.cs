using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Data_Access_Layer
{
    public class ConnectDB
    {
        #region 1.Khai báo các thành viên dữ liệu
        private SqlConnection conn;
        private SqlCommand cmd;
        #endregion 1

        #region 2.Phương thức khởi tạo
        public ConnectDB()
        {
            conn = new SqlConnection(@"Server=BNTHUYTHAO\SQLEXPRESS; Database=CHINHANHPHUCLONG; Integrated Security = True;");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                //MessageBox.Show("Connected!!!");
            }
        }
        #endregion

        #region 3.Các phương thức thao tác CSDL

        public DataTable getTableData(string select)
        {
            SqlDataAdapter da = new SqlDataAdapter(select, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void ExcuteSQLInsertOrDelete(string select)
        {
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = select;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            cmd1.ExecuteNonQuery();
            conn.Close();
        }
        public bool TonTaiKhoaChinh(string strGiaTri, string strTenTruong, string strTable)
        {
            bool blnResult = false;
            try
            {
                
                string sqlSelect = "Select 1 From " + strTable + " Where " + strTenTruong + "='" + strGiaTri + "'";
                //MessageBox.Show(sqlSelect);
                
                SqlCommand cmd2 = new SqlCommand();

                cmd2.Connection = conn;
                cmd2.CommandText = sqlSelect;
                //MessageBox.Show(conn.State.ToString());

                SqlDataReader drReader = cmd2.ExecuteReader();
                if (drReader.HasRows)
                    blnResult = true;
                drReader.Close();
                //conn.Close();
            }
            catch (Exception)
            {

            }
            return blnResult;
        }
        

        #endregion 3
    }
}
