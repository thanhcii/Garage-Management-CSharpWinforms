using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SamLop.Data
{
   public class SanPhamDAL : SqlDataProvider
    {
        #region[SanPham_GetbyAll]
        public DataTable SanPham_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_SanPham_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[SanPham_GetbyId]
        public DataTable SanPham_GetById(SanPhamInfo Data)
        {
            using (var cmd = new SqlCommand("sq_SanPham_GetById", GetConnection()))
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
        #region[SanPham_GetbyTop]
        public DataTable SanPham_GetByTop(string Top, string Where, string Order)
        {
            using (var cmd = new SqlCommand("sq_SanPham_GetByTop", GetConnection()))
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
        #region[SanPham_Insert]
        public void SanPham_Insert(SanPhamInfo Data)
        {
            using (var cmd = new SqlCommand("sq_SanPham_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@TenSanPham", Data.TenSanPham));
                cmd.Parameters.Add(new SqlParameter("@ID_NhomSP", Data.ID_NhomSP));
                cmd.Parameters.Add(new SqlParameter("@Giaban", Data.Giaban));
                cmd.Parameters.Add(new SqlParameter("@ID_NhaSX", Data.ID_NhaSX));  
                cmd.Parameters.Add(new SqlParameter("@Donvitinh", Data.Donvitinh));
                cmd.Parameters.Add(new SqlParameter("@Diengiai", Data.Diengiai));
                cmd.Parameters.Add(new SqlParameter("@Ghichu", Data.Ghichu));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[SanPham_Update]
        public void SanPham_Update(SanPhamInfo Data)
        {
            using (var cmd = new SqlCommand("sq_SanPham_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@TenSanPham", Data.TenSanPham));
                cmd.Parameters.Add(new SqlParameter("@Donvitinh", Data.Donvitinh));
                cmd.Parameters.Add(new SqlParameter("@Diengiai", Data.Diengiai));
                cmd.Parameters.Add(new SqlParameter("@Ghichu", Data.Ghichu));
                cmd.Parameters.Add(new SqlParameter("@Giaban", Data.Giaban));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[SanPham_Delete]
        public void SanPham_Delete(SanPhamInfo Data)
        {
            using (var cmd = new SqlCommand("sq_SanPham_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[sq_SanPham_Insertgia]
        public int SanPham_Updategia(SanPhamInfo Data)
        {
            SqlCommand cmd = new SqlCommand("sq_SanPham_Updategia", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
            cmd.Parameters.Add(new SqlParameter("@Giaban", Data.Giaban));
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