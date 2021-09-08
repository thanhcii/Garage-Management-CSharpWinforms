using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SamLop.Data
{
    public class ChiTietBaoTriDAL : SqlDataProvider
    {
        #region[ChiTietBaoTri_GetbyAll]
        public DataTable ChiTietBaoTri_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_ChiTietBaoTri_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[Chitiethoadonbaotri_GetbyAll]
        public DataTable Chitiethoadonbaotri_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_Chitiethoadonbaotri_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[Doanhthuthucte_GetbyAll]
        public DataTable Doanhthuthucte_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_Doanhthuthucte_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[Chitietnonhacungcap_GetbyAll]
        public DataTable Chitietnonhacungcap_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_Chitietnonhacungcap_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[Chitietthanhtoanno_GetbyAll]
        public DataTable Chitietthanhtoanno_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_Chitietthanhtoanno_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[Bangnokhachhang_GetbyAll]
        public DataTable Bangnokhachhang_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_Bangnokhachhang_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[ChiTietBaoTri_GetbyId]
        public DataTable ChiTietBaoTri_GetById(ChiTietBaoTriInfo Data)
        {
            using (var cmd = new SqlCommand("sq_ChiTietBaoTri_GetById", GetConnection()))
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
        #region[ChiTietBaoTri_GetbyTop]
        public DataTable ChiTietBaoTri_GetByTop(string Top, string Where, string Order)
        {
            using (var cmd = new SqlCommand("sq_ChiTietBaoTri_GetByTop", GetConnection()))
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
        #region[Bangnokhachhang_GetbyTop]
        public DataTable Bangnokhachhang_GetByTop(string Top, string Where, string Order)
        {
            using (var cmd = new SqlCommand("sq_Bangnokhachhang_GetByTop", GetConnection()))
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
        #region[TATTANTATVENHAPHANG_GetbyTop]
        public DataTable TATTANTATVENHAPHANG_GetByTop(string Top, string Where, string Order)
        {
            using (var cmd = new SqlCommand("sq_TATTANTATVENHAPHANG_GetByTop", GetConnection()))
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
        #region[CHIETXEBAOTRI_GetbyTop]
        public DataTable CHIETXEBAOTRI_GetByTop(string Top, string Where, string Order)
        {
            using (var cmd = new SqlCommand("sq_CHIETXEBAOTRI_GetByTop", GetConnection()))
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
        #region[XUATHANGTATTANTAT_GetbyTop]
        public DataTable XUATHANGTATTANTAT_GetByTop(string Top, string Where, string Order)
        {
            using (var cmd = new SqlCommand("sq_XUATHANGTATTANTAT_GetByTop", GetConnection()))
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
        #region[ChiTietBaoTri_Insert]
        public void ChiTietBaoTri_Insert(ChiTietBaoTriInfo Data)
        {
            using (var cmd = new SqlCommand("sq_ChiTietBaoTri_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@ID_SanPham", Data.ID_SanPham));
                cmd.Parameters.Add(new SqlParameter("@ID_NhanVien", Data.ID_NhanVien));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", Data.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@DonGia", Data.DonGia));
                cmd.Parameters.Add(new SqlParameter("@ThanhTien", Data.ThanhTien));
                cmd.Parameters.Add(new SqlParameter("@NgayNhap", Data.NgayNhap));
                cmd.Parameters.Add(new SqlParameter("@Chitietbaohanh", Data.Chitietbaohanh));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[ChiTietBaoTri_Update]
        public void ChiTietBaoTri_Update(ChiTietBaoTriInfo Data)
        {
            using (var cmd = new SqlCommand("sq_ChiTietBaoTri_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@ID_SanPham", Data.ID_SanPham));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", Data.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@DonGia", Data.DonGia));
                cmd.Parameters.Add(new SqlParameter("@ThanhTien", Data.ThanhTien));
                cmd.Parameters.Add(new SqlParameter("@NgayCapNhat", Data.NgayCapNhat));
                cmd.Parameters.Add(new SqlParameter("@NguoiCapNhat", Data.NguoiCapNhat));
                cmd.Parameters.Add(new SqlParameter("@NgayNhap", Data.NgayNhap));
                cmd.Parameters.Add(new SqlParameter("@Chitietbaohanh", Data.Chitietbaohanh));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[ChiTietBaoTri_Delete]
        public void ChiTietBaoTri_Delete(ChiTietBaoTriInfo Data)
        {
            using (var cmd = new SqlCommand("sq_ChiTietBaoTri_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@ID_SanPham", Data.ID_SanPham));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[ChiTietBaoTri_Kiemtra]
        public int ChiTietBaoTri_Kiemtra(string MaChiTietBaoTri)
        {
            SqlCommand cmd = new SqlCommand("sq_ChiTietBaoTri_KiemTra", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaChiTietBaoTri", MaChiTietBaoTri));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            { return 1; }

            else return -1;
        }
        #endregion
        #region[ChiTietBaoTri_Sum]
        public DataTable ChiTietBaoTri_Sum(ChiTietBaoTriInfo Data)
        {
            using (var cmd = new SqlCommand("sq_ChiTietBaoTri_Sum", GetConnection()))
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