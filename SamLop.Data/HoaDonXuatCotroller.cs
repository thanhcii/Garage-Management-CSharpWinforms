using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SamLop.Data
{
    public class HoaDonXuatDAL : SqlDataProvider
    {
        #region[HoaDonXuat_GetbyAll]
        public DataTable HoaDonXuat_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_HoaDonXuat_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[HoaDonXuat_GetbyId]
        public DataTable HoaDonXuat_GetById(HoaDonXuatInfo Data)
        {
            using (var cmd = new SqlCommand("sq_HoaDonXuat_GetById", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@ID_KhachHang", Data.ID_KhachHang));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[HoaDonXuat_GetbyTop]
        public DataTable HoaDonXuat_GetByTop(string Top, string Where, string Order)
        {
            using (var cmd = new SqlCommand("sq_HoaDonXuat_GetByTop", GetConnection()))
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
        #region[BAOCAOXUAT_GetbyTop]
        public DataTable BAOCAOXUAT_GetByTop(string Top, string Where, string Order)
        {
            using (var cmd = new SqlCommand("sq_BAOCAOXUAT_GetByTop", GetConnection()))
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
        #region[HoaDonXuat_Insert]
        public void HoaDonXuat_Insert(HoaDonXuatInfo Data)
        {
            using (var cmd = new SqlCommand("sq_HoaDonXuat_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@ID_NhanVien", Data.ID_NhanVien));
                cmd.Parameters.Add(new SqlParameter("@ID_KhachHang", Data.ID_KhachHang));
                cmd.Parameters.Add(new SqlParameter("@NgayNhap", Data.NgayNhap));
                cmd.Parameters.Add(new SqlParameter("@TongTien", Data.TongTien));
                cmd.Parameters.Add(new SqlParameter("@Datra", Data.Datra));
                cmd.Parameters.Add(new SqlParameter("@Phuphi", Data.Phuphi));
                cmd.Parameters.Add(new SqlParameter("@Quyen", Data.Quyen));
                cmd.Parameters.Add(new SqlParameter("@Trang", Data.Trang));

                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[HoaDonXuat_Update]
        public void HoaDonXuat_Update(HoaDonXuatInfo Data)
        {
            using (var cmd = new SqlCommand("sq_HoaDonXuat_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@NgayNhap", Data.NgayNhap));
                cmd.Parameters.Add(new SqlParameter("@TongTien", Data.TongTien));
                cmd.Parameters.Add(new SqlParameter("@Datra", Data.Datra));
                cmd.Parameters.Add(new SqlParameter("@ID_KhachHang", Data.ID_KhachHang));
                cmd.Parameters.Add(new SqlParameter("@NgayCapNhat", Data.NgayCapNhat));
                cmd.Parameters.Add(new SqlParameter("@NguoiCapNhat", Data.NguoiCapNhat));
                cmd.Parameters.Add(new SqlParameter("@Phuphi", Data.Phuphi));
                cmd.Parameters.Add(new SqlParameter("@Quyen", Data.Quyen));
                cmd.Parameters.Add(new SqlParameter("@Trang", Data.Trang));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[HoaDonXuat_Tien]
        public void HoaDonXuat_Tien(HoaDonXuatInfo Data)
        {
            using (var cmd = new SqlCommand("sq_HoaDonXuat_Tien", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@TongTien", Data.TongTien));
                cmd.Parameters.Add(new SqlParameter("@Phuphi", Data.Phuphi));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[HoaDonXuat_Delete]
        public void HoaDonXuat_Delete(HoaDonXuatInfo Data)
        {
            using (var cmd = new SqlCommand("sq_HoaDonXuat_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID)); 
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[HoaDonXuat_Kiemtra]
        public int HoaDonXuat_Kiemtra(string MaHoaDonXuat)
        {
            SqlCommand cmd = new SqlCommand("sq_HoaDonXuat_KiemTra", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaHoaDonXuat", MaHoaDonXuat));
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