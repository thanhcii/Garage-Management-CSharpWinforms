using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SamLop.Data
{
    public class HoaDonBaoTriDAL : SqlDataProvider
    {
        #region[HoaDonBaoTri_GetbyAll]
        public DataTable HoaDonBaoTri_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_HoaDonBaoTri_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[V_HOADONBAOTRI_GetbyAll]
        public DataTable V_HOADONBAOTRI_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_V_HOADONBAOTRI_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[HoaDonBaoTri_GetbyId]
        public DataTable HoaDonBaoTri_GetById(HoaDonBaoTriInfo Data)
        {
            using (var cmd = new SqlCommand("sq_HoaDonBaoTri_GetById", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@ID_Xe", Data.ID_Xe));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[HoaDonBaoTri_GetbyTop]
        public DataTable HoaDonBaoTri_GetByTop(string Top, string Where, string Order)
        {
            using (var cmd = new SqlCommand("sq_HoaDonBaoTri_GetByTop", GetConnection()))
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
        #region[V_HOADONBAOTRI_GetbyTop]
        public DataTable V_HOADONBAOTRI_GetByTop(string Top, string Where, string Order)
        {
            using (var cmd = new SqlCommand("sq_V_HOADONBAOTRI_GetByTop", GetConnection()))
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
        #region[HoaDonBaoTri_Insert]
        public void HoaDonBaoTri_Insert(HoaDonBaoTriInfo Data)
        {
            using (var cmd = new SqlCommand("sq_HoaDonBaoTri_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@ID_NhanVien", Data.ID_NhanVien));
                cmd.Parameters.Add(new SqlParameter("@ID_Xe", Data.ID_Xe));
                cmd.Parameters.Add(new SqlParameter("@NgayNhap", Data.NgayNhap));
                cmd.Parameters.Add(new SqlParameter("@TongTien", Data.TongTien));
                cmd.Parameters.Add(new SqlParameter("@Phuphi", Data.Phuphi));
                cmd.Parameters.Add(new SqlParameter("@CongViec", Data.CongViec));
                cmd.Parameters.Add(new SqlParameter("@Quyen", Data.Quyen));
                cmd.Parameters.Add(new SqlParameter("@Trang", Data.Trang));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[HoaDonBaoTri_Update]
        public void HoaDonBaoTri_Update(HoaDonBaoTriInfo Data)
        {
            using (var cmd = new SqlCommand("sq_HoaDonBaoTri_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@ID_Xe", Data.ID_Xe));  
                cmd.Parameters.Add(new SqlParameter("@NgayNhap", Data.NgayNhap));
                cmd.Parameters.Add(new SqlParameter("@TongTien", Data.TongTien));
                cmd.Parameters.Add(new SqlParameter("@Phuphi", Data.Phuphi));
                cmd.Parameters.Add(new SqlParameter("@CongViec", Data.CongViec));
                cmd.Parameters.Add(new SqlParameter("@NgayCapNhat", Data.NgayCapNhat));
                cmd.Parameters.Add(new SqlParameter("@NguoiCapNhat", Data.NguoiCapNhat));
                cmd.Parameters.Add(new SqlParameter("@Quyen", Data.Quyen));
                cmd.Parameters.Add(new SqlParameter("@Trang", Data.Trang));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region[HoaDonBaoTri_Tien]
        public void HoaDonBaoTri_Tien(HoaDonBaoTriInfo Data)
        {
            using (var cmd = new SqlCommand("sq_HoaDonBaoTri_Tien", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));          
                cmd.Parameters.Add(new SqlParameter("@TongTien", Data.TongTien));
                cmd.Parameters.Add(new SqlParameter("@Phuphi", Data.Phuphi));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[HoaDonBaoTri_Delete]
        public void HoaDonBaoTri_Delete(HoaDonBaoTriInfo Data)
        {
            using (var cmd = new SqlCommand("sq_HoaDonBaoTri_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[HoaDonBaoTri_Kiemtra]
        public int HoaDonBaoTri_Kiemtra(string MaHoaDonBaoTri)
        {
            SqlCommand cmd = new SqlCommand("sq_HoaDonBaoTri_KiemTra", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaHoaDonBaoTri", MaHoaDonBaoTri));
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