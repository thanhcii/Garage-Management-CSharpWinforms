using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SamLop.Data
{
    public class ChiTietNhapDAL : SqlDataProvider
    {
        #region[Chitiethoadonnhap_GetbyAll]
        public DataTable Chitiethoadonnhap_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_Chitiethoadonnhap_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[ChiTietNhap_GetbyAll]
        public DataTable ChiTietNhap_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_ChiTietNhap_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[ChiTietNhap_GetbyId]
        public DataTable ChiTietNhap_GetById(ChiTietNhapInfo Data)
        {
            using (var cmd = new SqlCommand("sq_ChiTietNhap_GetById", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID_HoaDon", Data.ID_HoaDon));
                cmd.Parameters.Add(new SqlParameter("@ID_SanPham", Data.ID_SanPham));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[ChiTietNhap_GetbyTop]
        public DataTable ChiTietNhap_GetByTop(string Top, string Where, string Order)
        {
            using (var cmd = new SqlCommand("sq_ChiTietNhap_GetByTop", GetConnection()))
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
        #region[Chitiethoadonnhap_GetByTop]
        public DataTable Chitiethoadonnhap_GetByTop(string Where)
        {
            using (var cmd = new SqlCommand("sq_Chitiethoadonnhap_GetByTop", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd); 
                cmd.Parameters.Add(new SqlParameter("@Where", Where));
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[ChiTietNhap_Insert]
        public void ChiTietNhap_Insert(ChiTietNhapInfo Data)
        {
            using (var cmd = new SqlCommand("sq_ChiTietNhap_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID_HoaDon", Data.ID_HoaDon));
                cmd.Parameters.Add(new SqlParameter("@ID_SanPham", Data.ID_SanPham));
                cmd.Parameters.Add(new SqlParameter("@ID_NhanVien", Data.ID_NhanVien));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", Data.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@GiaCu", Data.GiaCu));
                cmd.Parameters.Add(new SqlParameter("@GiaMoi", Data.GiaMoi));
                cmd.Parameters.Add(new SqlParameter("@ThanhTien", Data.ThanhTien));
                cmd.Parameters.Add(new SqlParameter("@NgayNhap", Data.NgayNhap));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[ChiTietNhap_Update]
        public void ChiTietNhap_Update(ChiTietNhapInfo Data)
        {
            using (var cmd = new SqlCommand("sq_ChiTietNhap_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID_HoaDon", Data.ID_HoaDon));
                cmd.Parameters.Add(new SqlParameter("@ID_SanPham", Data.ID_SanPham));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", Data.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@GiaCu", Data.GiaCu));
                cmd.Parameters.Add(new SqlParameter("@GiaMoi", Data.GiaMoi));
                cmd.Parameters.Add(new SqlParameter("@ThanhTien", Data.ThanhTien));
                cmd.Parameters.Add(new SqlParameter("@NgayCapNhat", Data.NgayCapNhat));
                cmd.Parameters.Add(new SqlParameter("@NgayNhap", Data.NgayNhap));
                cmd.Parameters.Add(new SqlParameter("@NguoiCapNhat", Data.NguoiCapNhat));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[ChiTietNhap_Delete]
        public void ChiTietNhap_Delete(ChiTietNhapInfo Data)
        {
            using (var cmd = new SqlCommand("sq_ChiTietNhap_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID_HoaDon", Data.ID_HoaDon));
                cmd.Parameters.Add(new SqlParameter("@ID_SanPham", Data.ID_SanPham));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[ChiTietNhap_Sum]
        public DataTable ChiTietNhap_Sum(ChiTietNhapInfo Data)
        {
            using (var cmd = new SqlCommand("sq_ChiTietNhap_Sum", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add(new SqlParameter("@ID_HoaDon", Data.ID_HoaDon));
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
    }
}
