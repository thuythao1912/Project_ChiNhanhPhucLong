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
    public class DanhGia
    {
        #region 1. Khai báo các thành viên dữ liệu
        private int _dg_id;

        public int Dg_id
        {
            get { return _dg_id; }
            set { _dg_id = value; }
        }
        private string _cn_id;

        public string Cn_id
        {
            get { return _cn_id; }
            set { _cn_id = value; }
        }
        private string _dg_noidung;

        public string Dg_noidung
        {
            get { return _dg_noidung; }
            set { _dg_noidung = value; }
        }

        #endregion

        #region 2. cac phuong thuc khoi tao
        public DanhGia() {
            Dg_id = 0;
            Cn_id = "";
            Dg_noidung = "";
        }
        #endregion

        #region 3.cac phuong thuc khac
            public string LoadDanhGiaTheoChiNhanh(string cn_id) {
                string str = "";
                DataTable tb = new DataTable();
                ReadTable("exec getDanhGiaTheoChiNhanh '" + cn_id + "'");

                if (CountRow() > 0)
                {
                    for (int i = 0; i < CountRow(); i++) {
                        GetRecord(i);
                        str += Dg_id + " - " + Dg_noidung + "\n";
                    }
                }
                return str;
                
        }
        #endregion

            #region 4.thao tac voi CSDL
            private ConnectDB cn = new ConnectDB();
            private DataTable dt = new DataTable();

            private void ReadTable()
            {
                dt = cn.getTableData("select * from DANHGIA");
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
                Dg_id = Int32.Parse(dt.Rows[i]["DG_ID"].ToString());
                Cn_id = dt.Rows[i]["CN_ID"].ToString();
                Dg_noidung = dt.Rows[i]["DG_NOIDUNG"].ToString();
            }
           

            public DataTable GetTable()
            {
                return dt;
            }


            public void AddRecord()
            {
                string Caulenh = null;
                Caulenh = "INSERT INTO DANHGIA VALUES (N'" + Cn_id + "', N'" + Dg_noidung + "')";
                //MessageBox.Show(Caulenh);
                cn.ExcuteSQLInsertOrDelete(Caulenh);
                MessageBox.Show("Đã lưu đánh giá!", "Thông báo");
            }
        #endregion
    }
}
