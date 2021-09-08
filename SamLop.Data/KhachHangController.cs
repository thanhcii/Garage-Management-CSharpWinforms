using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SamLop.Data
{
   public class KhachHangDAL : SqlDataProvider
    {
        #region[KhachHang_GetbyAll]
        public DataTable KhachHang_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_KhachHang_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[KhachHang_GetbyId]
        public DataTable KhachHang_GetById(KhachHangInfo Data)
        {
            using (var cmd = new SqlCommand("sq_KhachHang_GetById", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[KhachHang_GetbyTop]
        public DataTable KhachHang_GetByTop(string Top, string Where, string Order)
        {
            using (var cmd = new SqlCommand("sq_KhachHang_GetByTop", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add(new SqlParameter("@Top", Top));
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                cmd.Parameters.Add(new SqlParameter("@Order", Order));
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[KhachHang_Insert]
        public void KhachHang_Insert(KhachHangInfo Data)
        {
            using (var cmd = new SqlCommand("sq_KhachHang_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@TenKhachHang", Data.TenKhachHang));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", Data.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@SDT", Data.SDT));
                cmd.Parameters.Add(new SqlParameter("@Email", Data.Email));
                cmd.Parameters.Add(new SqlParameter("@SoTK", Data.SoTK));
                cmd.Parameters.Add(new SqlParameter("@NganHang", Data.NganHang));
                cmd.Parameters.Add(new SqlParameter("@MaST", Data.MaST));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[KhachHang_Update]
        public void KhachHang_Update(KhachHangInfo Data)
        {
            using (var cmd = new SqlCommand("sq_KhachHang_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@TenKhachHang", Data.TenKhachHang));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", Data.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@SDT", Data.SDT));
                cmd.Parameters.Add(new SqlParameter("@Email", Data.Email));
                cmd.Parameters.Add(new SqlParameter("@SoTK", Data.SoTK));
                cmd.Parameters.Add(new SqlParameter("@NganHang", Data.NganHang));
                cmd.Parameters.Add(new SqlParameter("@MaST", Data.MaST));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[KhachHang_Delete]
        public void KhachHang_Delete(KhachHangInfo Data)
        {
            using (var cmd = new SqlCommand("sq_KhachHang_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[KhachHang_Kiemtra]
        public int KhachHang_Kiemtra(string MaKhachHang)
        {
            SqlCommand cmd = new SqlCommand("sq_KhachHang_KiemTra", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaKhachHang", MaKhachHang));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            { return 1; }

            else return -1;
        }
        #endregion
    }
}