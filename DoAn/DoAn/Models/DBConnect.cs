using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAn.Models
{
    public class DBConnect
    {
        public string strConnect = "Server=MINHDUC\\SQLEXPRESS;Database=QLDoAn;Integrated Security=True";
        public SqlConnection conn;

        public DBConnect()
        {
            conn = new SqlConnection(strConnect);
        }

        public DBConnect(string strConnect)
        {
            conn = new SqlConnection(strConnect);
        }
        public void Open()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void Close()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        public int getNonQuery(string strInsert)
        {
            Open();
            SqlCommand cmd = new SqlCommand(strInsert, conn);


            int kq = cmd.ExecuteNonQuery();
            Close();
            return kq;
        }
        public object getScalar(string chuoiTruyVan)
        {
            Open();
            SqlCommand cmd = new SqlCommand(chuoiTruyVan, conn);
            object kq = cmd.ExecuteScalar();
            Close();
            return kq;
        }
        public DataTable getDataTable(string chuoiTruyVan)
        {
            SqlDataAdapter da = new SqlDataAdapter(chuoiTruyVan, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public int updateDataTable(DataTable dt, string chuoitruyvan)
        {
            SqlDataAdapter da = new SqlDataAdapter(chuoitruyvan, conn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            int kq = da.Update(dt);
            return kq;
        }
        public DataSet GetDataSet(string chuoiTruyVan)
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter(chuoiTruyVan, conn);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            Close();
            return dataSet;
        }
        

        public List<LoaiKS> GetLoaiKSs()
        {
            List<LoaiKS> lst = new List<LoaiKS> ();
            Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from LoaiKS";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                LoaiKS ks = new LoaiKS();
                ks.ma = reader.GetString(0);
                ks.tenloai = reader.GetString(1);
                lst.Add(ks);
            }

            reader.Close();

            return lst;
        }
        public List<NhanVien> getNhanVien()
        {
            List<NhanVien> lst = new List<NhanVien>();
            Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from NhanVien";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                NhanVien nv = new NhanVien();
                nv.manv = reader.GetString(0);
                nv.tennv = reader.GetString(1);
                lst.Add(nv);
            }

            reader.Close();

            return lst;
        }
        public List<KhachHang> getKhachHang()
        {
            List<KhachHang> lst = new List<KhachHang>();
            Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from KhachHang";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                KhachHang kh = new KhachHang();
                kh.MaKH = reader.GetString(0);
                kh.TenKH = reader.GetString(1);
                lst.Add(kh);
            }

            reader.Close();

            return lst;
        }
        public List<Tours> getTours()
        {
            List<Tours> lst = new List<Tours>();
            Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from Tours";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Tours t = new Tours();
                t.matour = reader.GetString(0);
                t.tentour = reader.GetString(1);
                lst.Add(t);
            }

            reader.Close();

            return lst;
        }
        public List<DiemBD> getDiemBD()
        {
            List<DiemBD> lst = new List<DiemBD>();
            Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from DiemBD";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DiemBD bd = new DiemBD();
                bd.madiembd = reader.GetString(0);
                bd.tendiembd = reader.GetString(1);
                lst.Add(bd);
            }

            reader.Close();

            return lst;
        }
        public List<diemkt> getDiemKT()
        {
            List<diemkt> lst = new List<diemkt>();
            Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from DiemKT";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                diemkt kt = new diemkt();
                kt.madiemkt = reader.GetString(0);
                kt.tendiemkt = reader.GetString(1);
                lst.Add(kt);
            }

            reader.Close();

            return lst;
        }
        public List<KhachSan> getKS()
        {
            List<KhachSan> lst = new List<KhachSan>();
            Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from KhachSan";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                KhachSan ks = new KhachSan();
                ks.MaKS = reader.GetString(0);
                ks.TenKS = reader.GetString(1);
                lst.Add(ks);
            }

            reader.Close();

            return lst;
        }
        public List<HoaDon> getHD()
        {
            List<HoaDon> lst = new List<HoaDon>();
            Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from HoaDon";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                HoaDon hd = new HoaDon();
                hd.mahd = reader.GetString(0);
                lst.Add(hd);
            }

            reader.Close();

            return lst;
        }
        public List<PhuongTien> getPT()
        {
            List<PhuongTien> lst = new List<PhuongTien>();
            Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from PhuongTien";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PhuongTien pt = new PhuongTien();
                pt.mapt = reader.GetString(0);
                pt.tenpt = reader.GetString(1);
                lst.Add(pt);
            }

            reader.Close();

            return lst;
        }
    }
}
