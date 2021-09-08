using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SamLop.Data
{
   public class XeBaoTriDAL : SqlDataProvider
    {
        #region[XeBaoTri_GetbyAll]
        public DataTable XeBaoTri_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_XeBaoTri_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[XeBaoTri_GetbyId]
        public DataTable XeBaoTri_GetById(XeBaoTriInfo Data)
        {
            using (var cmd = new SqlCommand("sq_XeBaoTri_GetById", GetConnection()))
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
        #region[XeBaoTri_GetbyTop]
        public DataTable XeBaoTri_GetByTop(string Top, string Where, string Order)
        {
            using (var cmd = new SqlCommand("sq_XeBaoTri_GetByTop", GetConnection()))
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
        #region[XeBaoTri_Insert]
        public void XeBaoTri_Insert(XeBaoTriInfo Data)
        {
            using (var cmd = new SqlCommand("sq_XeBaoTri_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@NgayNhap", Data.NgayNhap));
                cmd.Parameters.Add(new SqlParameter("@ID_KhachHang", Data.ID_KhachHang));
                cmd.Parameters.Add(new SqlParameter("@ID_NhanVien", Data.ID_NhanVien));
                cmd.Parameters.Add(new SqlParameter("@YeuCau", Data.YeuCau));
                cmd.Parameters.Add(new SqlParameter("@Mota", Data.Mota));
                cmd.Parameters.Add(new SqlParameter("@TinhTrang", Data.TinhTrang));
                cmd.Parameters.Add(new SqlParameter("@NgayNhan", Data.NgayNhan));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[XeBaoTri_Update]
        public void XeBaoTri_Update(XeBaoTriInfo Data)
        {
            using (var cmd = new SqlCommand("sq_XeBaoTri_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@NgayNhap", Data.NgayNhap));
                cmd.Parameters.Add(new SqlParameter("@ID_KhachHang", Data.ID_KhachHang));
                cmd.Parameters.Add(new SqlParameter("@YeuCau", Data.YeuCau));
                cmd.Parameters.Add(new SqlParameter("@Mota", Data.Mota));
                cmd.Parameters.Add(new SqlParameter("@TinhTrang", Data.TinhTrang));
                cmd.Parameters.Add(new SqlParameter("@NgayCapNhat", Data.NgayCapNhat));
                cmd.Parameters.Add(new SqlParameter("@NguoiCapNhat", Data.NguoiCapNhat));
                cmd.Parameters.Add(new SqlParameter("@NgayNhan", Data.NgayNhan));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[XeBaoTri_Delete]
        public void XeBaoTri_Delete(XeBaoTriInfo Data)
        {
            using (var cmd = new SqlCommand("sq_XeBaoTri_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@NgayNhap", Data.NgayNhap));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[XeBaoTri_Kiemtra]
        public int XeBaoTri_Kiemtra(string MaXeBaoTri)
        {
            SqlCommand cmd = new SqlCommand("sq_XeBaoTri_KiemTra", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaXeBaoTri", MaXeBaoTri));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            { return 1; }

            else return -1;
        }
        #endregion


        #region[XeBaoTri_Updatexong]
        public void XeBaoTri_Updatexong(XeBaoTriInfo Data)
        {
            using (var cmd = new SqlCommand("sq_XeBaoTri_Updatexong", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
    }
}