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
    public class TinhThanh
    {
        #region 1.khai bao du lieu
        private string _tt_id;

        public string Tt_id
        {
            get { return _tt_id; }
            set { _tt_id = value; }
        }
        private string _vung_id;

        public string Vung_id
        {
            get { return _vung_id; }
            set { _vung_id = value; }
        }
        private string _tt_ten;

        public string Tt_ten
        {
            get { return _tt_ten; }
            set { _tt_ten = value; }
        }

        private string _vung_ten;

        public string Vung_ten
        {
            get { return _vung_ten; }
            set { _vung_ten = value; }
        }
        #endregion

        #region 2. cac phuong thuc khoi tao
        public TinhThanh() {
            Tt_id = "";
            Vung_id = "";
            Tt_ten = "";
            Vung_ten = "";
        }
        #endregion
        #region 3.cac phuong thuc khac
        public void LoadTinhThanhDetail(string tt_id)
        {
            DataTable tb = new DataTable();
            ReadTable("exec getTinhThanhDetail '" + tt_id + "'");

            if (CountRow() > 0)
            {
                GetRecordTinhThanh(0);

            }
            else {
                MessageBox.Show("Chưa có dữ liệu tỉnh thành!", "Thông báo");
            }
        }
        public void LoadcboTinhThanh(ComboBox cbo)
        {
            DataTable tb = new DataTable();
            ReadTable();
            tb.Columns.Add("TT_ID", typeof(String));
            tb.Columns.Add("TT_TEN", typeof(string));
            tb.Columns.Add("TONG", typeof(string), "TT_ID + '  ' + TT_TEN");
            for (int i = 0; i < CountRow(); i++)
            {
                GetRecord(i);
                tb.Rows.Add(Tt_id, _tt_ten);
            }

            cbo.DataSource = tb;
            cbo.DisplayMember = "TONG";
            cbo.ValueMember = "TT_ID";

        }
        #endregion

        #region 4.thao tac voi CSDL
        private ConnectDB cn = new ConnectDB();
        private DataTable dt = new DataTable();

        private void ReadTable()
        {
            dt = cn.getTableData("select * from TINHTHANH");
        }
        private void ReadTable(String sql)
        {
            dt = cn.getTableData(sql);
        }

        public int CountRow()
        {
            return dt.Rows.Count;
        }
        public void GetRecordTinhThanh(int i)
        {
            Tt_id = dt.Rows[i]["TT_ID"].ToString();
            Tt_ten = dt.Rows[i]["TT_TEN"].ToString();
            Vung_id = dt.Rows[i]["VUNG_ID"].ToString();
            Vung_ten = dt.Rows[i]["VUNG_TEN"].ToString();
        }
        public void GetRecord(int i)
        {
            Tt_id = dt.Rows[i]["TT_ID"].ToString();
            Tt_ten = dt.Rows[i]["TT_TEN"].ToString();
            Vung_id = dt.Rows[i]["VUNG_ID"].ToString();
        }


        public DataTable GetTable()
        {
            return dt;
        }


       
        #endregion


    }
}
