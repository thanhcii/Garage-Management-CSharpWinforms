using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SamLop.Data
{
   public  class ChiTietXuatDAL : SqlDataProvider
    {
        #region[ChiTietXuat_GetbyAll]
        public DataTable ChiTietXuat_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_ChiTietXuat_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[Chitiethoadonxuat_GetbyAll]
        public DataTable Chitiethoadonxuat_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_Chitiethoadonxuat_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[ChiTietXuat_GetbyId]
        public DataTable ChiTietXuat_GetById(ChiTietXuatInfo Data)
        {
            using (var cmd = new SqlCommand("sq_ChiTietXuat_GetById", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@ID_SanPham", Data.ID_SanPham));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[ChiTietXuat_GetbyTop]
        public DataTable ChiTietXuat_GetByTop(string Top, string Where, string Order)
        {
            using (var cmd = new SqlCommand("sq_ChiTietXuat_GetByTop", GetConnection()))
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
        #region[ChiTietXuat_Insert]
        public void ChiTietXuat_Insert(ChiTietXuatInfo Data)
        {
            using (var cmd = new SqlCommand("sq_ChiTietXuat_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@ID_SanPham", Data.ID_SanPham));
                cmd.Parameters.Add(new SqlParameter("@ID_NhanVien", Data.ID_NhanVien));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", Data.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@DonGia", Data.DonGia));
                cmd.Parameters.Add(new SqlParameter("@ThanhTien", Data.ThanhTien));
                cmd.Parameters.Add(new SqlParameter("@NgayNhap", Data.NgayNhap));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[ChiTietXuat_Update]
        public void ChiTietXuat_Update(ChiTietXuatInfo Data)
        {
            using (var cmd = new SqlCommand("sq_ChiTietXuat_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@ID_SanPham", Data.ID_SanPham));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", Data.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@DonGia", Data.DonGia));
                cmd.Parameters.Add(new SqlParameter("@ThanhTien", Data.ThanhTien));
                cmd.Parameters.Add(new SqlParameter("@NgayNhap", Data.NgayNhap));
                cmd.Parameters.Add(new SqlParameter("@NgayCapNhat", Data.NgayCapNhat));
                cmd.Parameters.Add(new SqlParameter("@NguoiCapNhat", Data.NguoiCapNhat));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[ChiTietXuat_Delete]
        public void ChiTietXuat_Delete(ChiTietXuatInfo Data)
        {
            using (var cmd = new SqlCommand("sq_ChiTietXuat_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@ID_SanPham", Data.ID_SanPham));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[ChiTietXuat_Kiemtra]
        public int ChiTietXuat_Kiemtra(string MaChiTietXuat)
        {
            SqlCommand cmd = new SqlCommand("sq_ChiTietXuat_KiemTra", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaChiTietXuat", MaChiTietXuat));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            { return 1; }

            else return -1;
        }
        #endregion
        #region[ChiTietXuat_Sum]
        public DataTable ChiTietXuat_Sum(ChiTietXuatInfo Data)
        {
            using (var cmd = new SqlCommand("sq_ChiTietXuat_Sum", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
    }
}