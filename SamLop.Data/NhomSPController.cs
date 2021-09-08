using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SamLop.Data
{
    public class NhomSPDAL : SqlDataProvider
    {
        #region[NhomSP_GetbyAll]
        public DataTable NhomSP_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_NhomSP_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[NhomSP_GetbyId]
        public DataTable NhomSP_GetById(NhomSPInfo Data)
        {
            using (var cmd = new SqlCommand("sq_NhomSP_GetById", GetConnection()))
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
        #region[NhomSP_GetbyTop]
        public DataTable NhomSP_GetByTop(string Top, string Where, string Order)
        {
            using (var cmd = new SqlCommand("sq_NhomSP_GetByTop", GetConnection()))
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
        #region[NhomSP_Insert]
        public void NhomSP_Insert(NhomSPInfo Data)
        {
            using (var cmd = new SqlCommand("sq_NhomSP_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@Ten", Data.Ten));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[NhomSP_Update]
        public void NhomSP_Update(NhomSPInfo Data)
        {
            using (var cmd = new SqlCommand("sq_NhomSP_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@Ten", Data.Ten));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[NhomSP_Delete]
        public void NhomSP_Delete(NhomSPInfo Data)
        {
            using (var cmd = new SqlCommand("sq_NhomSP_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[NhomSP_Kiemtra]
        public int NhomSP_Kiemtra(string MaNhomSP)
        {
            SqlCommand cmd = new SqlCommand("sq_NhomSP_KiemTra", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNhomSP", MaNhomSP));
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