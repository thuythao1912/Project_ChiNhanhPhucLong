using _3.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Business_Logic_Layer
{
    public class Vung
    {
        private string _vung_id;

        public string Vung_id
        {
            get { return _vung_id; }
            set { _vung_id = value; }
        }
        private string _vung_ten;

        public string Vung_ten
        {
            get { return _vung_ten; }
            set { _vung_ten = value; }
        }
        
        #region 2. cac phuong thuc khoi tao
        public Vung() {
            Vung_id = "";
            Vung_ten = "";
        }
        #endregion

        #region 3.cac phuong thuc khac
        public void LoadVungDetail(string vung_id)
        {
            DataTable tb = new DataTable();
            ReadTable("exec getVungDetail '" + vung_id + "'");

            if (CountRow() > 0)
            {
                GetRecord(0);

            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu vùng!", "Thông báo");
            }
        }
        #endregion

        #region 4.thao tac voi CSDL
        private ConnectDB cn = new ConnectDB();
        private DataTable dt = new DataTable();

        private void ReadTable()
        {
            dt = cn.getTableData("select * from VUNG");
        }
        private void ReadTable(String sql)
        {
            dt = cn.getTableData(sql);
        }

        public int CountRow()
        {
            return dt.Rows.Count;
        }
        public void GetRecord(int i)
        {
            Vung_id = dt.Rows[i]["VUNG_ID"].ToString();
            Vung_ten = dt.Rows[i]["VUNG_TEN"].ToString();
        }


        public DataTable GetTable()
        {
            return dt;
        }



        #endregion

    }
}
