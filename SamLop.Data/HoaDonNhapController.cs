using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SamLop.Data
{
    public class HoaDonNhapDAL : SqlDataProvider
    {
        #region[HoaDonNhap_GetbyAll]
        public DataTable HoaDonNhap_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_HoaDonNhap_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[HoaDonNhap_GetbyId]
        public DataTable HoaDonNhap_GetById(HoaDonNhapInfo Data)
        {
            using (var cmd = new SqlCommand("sq_HoaDonNhap_GetById", GetConnection()))
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
        #region[HoaDonNhap_GetbyTop]
        public DataTable HoaDonNhap_GetByTop(string Top, string Where, string Order)
        {
            using (var cmd = new SqlCommand("sq_HoaDonNhap_GetByTop", GetConnection()))
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
        #region[Baocaonhap_GetByTop]
        public DataTable Baocaonhap_GetByTop(string Where)
        {
            using (var cmd = new SqlCommand("sq_Baocaonhap_GetByTop", GetConnection()))
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
        #region[HoaDonNhap_Insert]
        public void HoaDonNhap_Insert(HoaDonNhapInfo Data)
        {
            using (var cmd = new SqlCommand("sq_HoaDonNhap_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@ID_NhaCC", Data.ID_NhaCC));
                cmd.Parameters.Add(new SqlParameter("@ID_NhanVien", Data.ID_NhanVien));
                cmd.Parameters.Add(new SqlParameter("@NgayNhap", Data.NgayNhap));
                cmd.Parameters.Add(new SqlParameter("@TongTien", Data.TongTien));
                cmd.Parameters.Add(new SqlParameter("@Datra", Data.Datra));
                cmd.Parameters.Add(new SqlParameter("@Quyen", Data.Quyen));
                cmd.Parameters.Add(new SqlParameter("@Trang", Data.Trang));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[HoaDonNhap_Update]
        public void HoaDonNhap_Update(HoaDonNhapInfo Data)
        {
            using (var cmd = new SqlCommand("sq_HoaDonNhap_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@ID_NhaCC", Data.ID_NhaCC));
                cmd.Parameters.Add(new SqlParameter("@TongTien", Data.TongTien));
                cmd.Parameters.Add(new SqlParameter("@Datra", Data.Datra));
                cmd.Parameters.Add(new SqlParameter("@Ngaynhap", Data.NgayNhap));
                cmd.Parameters.Add(new SqlParameter("@NgayCapNhat", Data.NgayCapNhap));
                cmd.Parameters.Add(new SqlParameter("@NguoiCN", Data.NguoiCN));
                cmd.Parameters.Add(new SqlParameter("@Quyen", Data.Quyen));
                cmd.Parameters.Add(new SqlParameter("@Trang", Data.Trang));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[HoaDonNhap_Tien]
        public void HoaDonNhap_Tien(HoaDonNhapInfo Data)
        {
            using (var cmd = new SqlCommand("sq_HoaDonNhap_Tien", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@TongTien", Data.TongTien));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[HoaDonNhap_Delete]
        public void HoaDonNhap_Delete(HoaDonNhapInfo Data)
        {
            using (var cmd = new SqlCommand("sq_HoaDonNhap_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[HoaDonNhap_Kiemtra]
        public int HoaDonNhap_Kiemtra(string MaHoaDonNhap)
        {
            SqlCommand cmd = new SqlCommand("sq_HoaDonNhap_KiemTra", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaHoaDonNhap", MaHoaDonNhap));
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