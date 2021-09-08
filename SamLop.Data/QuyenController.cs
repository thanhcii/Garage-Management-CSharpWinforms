using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SamLop.Data
{
    public class QuyenDAL : SqlDataProvider
    {
        #region[Quyen_GetbyAll]
        public DataTable Quyen_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_Quyen_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[Quyen_GetbyId]
        public DataTable Quyen_GetById(QuyenInfo Data)
        {
            using (var cmd = new SqlCommand("sq_Quyen_GetById", GetConnection()))
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
        #region[Quyen_GetbyTop]
        public DataTable Quyen_GetByTop(string Top, string Where, string Order)
        {
            using (var cmd = new SqlCommand("sq_Quyen_GetByTop", GetConnection()))
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
        #region[Quyen_Insert]
        public void Quyen_Insert(QuyenInfo Data)
        {
            using (var cmd = new SqlCommand("sq_Quyen_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenQuyen", Data.TenQuyen));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[Quyen_Update]
        public void Quyen_Update(QuyenInfo Data)
        {
            using (var cmd = new SqlCommand("sq_Quyen_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@TenQuyen", Data.TenQuyen));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[Quyen_Delete]
        public void Quyen_Delete(QuyenInfo Data)
        {
            using (var cmd = new SqlCommand("sq_Quyen_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[Quyen_Kiemtra]
        public int Quyen_Kiemtra(string MaQuyen)
        {
            SqlCommand cmd = new SqlCommand("sq_Quyen_KiemTra", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaQuyen", MaQuyen));
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