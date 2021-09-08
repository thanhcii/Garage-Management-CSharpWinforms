using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SamLop.Data
{
    public class NhaSanXuatDAL : SqlDataProvider
    {
        #region[NhaSanXuat_GetbyAll]
        public DataTable NhaSanXuat_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_NhaSanXuat_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[NhaSanXuat_GetbyId]
        public DataTable NhaSanXuat_GetById(NhaSanXuatInfo Data)
        {
            using (var cmd = new SqlCommand("sq_NhaSanXuat_GetById", GetConnection()))
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
        #region[NhaSanXuat_GetbyTop]
        public DataTable NhaSanXuat_GetByTop(string Top, string Where, string Order)
        {
            using (var cmd = new SqlCommand("sq_NhaSanXuat_GetByTop", GetConnection()))
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
        #region[NhaSanXuat_Insert]
        public void NhaSanXuat_Insert(NhaSanXuatInfo Data)
        {
            using (var cmd = new SqlCommand("sq_NhaSanXuat_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@TenNhaSX", Data.TenNhaSX));
                cmd.Parameters.Add(new SqlParameter("@Mota", Data.Mota));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[NhaSanXuat_Update]
        public void NhaSanXuat_Update(NhaSanXuatInfo Data)
        {
            using (var cmd = new SqlCommand("sq_NhaSanXuat_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@TenNhaSX", Data.TenNhaSX));
                cmd.Parameters.Add(new SqlParameter("@Mota", Data.Mota));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[NhaSanXuat_Delete]
        public void NhaSanXuat_Delete(NhaSanXuatInfo Data)
        {
            using (var cmd = new SqlCommand("sq_NhaSanXuat_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[NhaSanXuat_Kiemtra]
        public int NhaSanXuat_Kiemtra(string MaNhaSanXuat)
        {
            SqlCommand cmd = new SqlCommand("sq_NhaSanXuat_KiemTra", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNhaSanXuat", MaNhaSanXuat));
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