using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SamLop.Data
{
    public class NhanVienDAL : SqlDataProvider
    {
        #region[NhanVien_GetbyAll]
        public DataTable NhanVien_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_NhanVien_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[NhanVien_GetbyId]
        public DataTable NhanVien_GetById(NhanVienInfo Data)
        {
            using (var cmd = new SqlCommand("sq_NhanVien_GetById", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Username", Data.Username));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[NhanVien_GetbyTop]
        public DataTable NhanVien_GetByTop(string Top, string Where, string Order)
        {
            using (var cmd = new SqlCommand("sq_NhanVien_GetByTop", GetConnection()))
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
        #region[NhanVien_Insert]
        public void NhanVien_Insert(NhanVienInfo Data)
        {
            using (var cmd = new SqlCommand("sq_NhanVien_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Username", Data.Username));
                cmd.Parameters.Add(new SqlParameter("@Password", Data.Password));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", Data.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@SDT", Data.SDT));
                cmd.Parameters.Add(new SqlParameter("@Ten", Data.Ten));
                cmd.Parameters.Add(new SqlParameter("@SoCMTND", Data.SoCMTND));
                cmd.Parameters.Add(new SqlParameter("@TinhTrang", Data.TinhTrang));
                cmd.Parameters.Add(new SqlParameter("@Email", Data.Email));
                cmd.Parameters.Add(new SqlParameter("@SoTK", Data.SoTK));
                cmd.Parameters.Add(new SqlParameter("@QuyenHan", Data.QuyenHan));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[NhanVien_Update]
        public void NhanVien_Update(NhanVienInfo Data)
        {
            using (var cmd = new SqlCommand("sq_NhanVien_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Ten", Data.Ten));
                cmd.Parameters.Add(new SqlParameter("@SoCMTND", Data.SoCMTND));
                cmd.Parameters.Add(new SqlParameter("@TinhTrang", Data.TinhTrang));
                cmd.Parameters.Add(new SqlParameter("@Username", Data.Username));
                cmd.Parameters.Add(new SqlParameter("@Password", Data.Password));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", Data.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@SDT", Data.SDT));
                cmd.Parameters.Add(new SqlParameter("@Email", Data.Email));
                cmd.Parameters.Add(new SqlParameter("@SoTK", Data.SoTK));
                cmd.Parameters.Add(new SqlParameter("@QuyenHan", Data.QuyenHan));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[NhanVien_Doithongtincanhan]
        public void NhanVien_Doithongtincanhan(NhanVienInfo Data)
        {
            using (var cmd = new SqlCommand("sq_NhanVien_Doithongtincanhan", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Username", Data.Username));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", Data.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@SDT", Data.SDT));
                cmd.Parameters.Add(new SqlParameter("@Email", Data.Email));
                cmd.Parameters.Add(new SqlParameter("@SoTK", Data.SoTK));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[NhanVien_DoiMatKhau]
        public void NhanVien_DoiMatKhau(NhanVienInfo Data)
        {
            using (var cmd = new SqlCommand("sq_NhanVien_DoiMatKhau", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Username", Data.Username));
                cmd.Parameters.Add(new SqlParameter("@Password", Data.Password));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[NhanVien_Delete]
        public void NhanVien_Delete(NhanVienInfo Data)
        {
            using (var cmd = new SqlCommand("sq_NhanVien_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Username", Data.Username));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[NhanVien_Kiemtra]
        public int NhanVien_Kiemtra(string MaNhanVien)
        {
            SqlCommand cmd = new SqlCommand("sq_NhanVien_KiemTra", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNhanVien", MaNhanVien));
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