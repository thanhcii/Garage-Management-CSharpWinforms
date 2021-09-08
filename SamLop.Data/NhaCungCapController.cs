using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SamLop.Data
{
    public class NhaCungCapDAL : SqlDataProvider
    {
        #region[NhaCungCap_GetbyAll]
        public DataTable NhaCungCap_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_NhaCungCap_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[NhaCungCap_GetbyId]
        public DataTable NhaCungCap_GetById(NhaCungCapInfo Data)
        {
            using (var cmd = new SqlCommand("sq_NhaCungCap_GetById", GetConnection()))
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
        #region[NhaCungCap_GetbyTop]
        public DataTable NhaCungCap_GetByTop(string Top, string Where, string Order)
        {
            using (var cmd = new SqlCommand("sq_NhaCungCap_GetByTop", GetConnection()))
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
        #region[NhaCungCap_Insert]
        public void NhaCungCap_Insert(NhaCungCapInfo Data)
        {
            using (var cmd = new SqlCommand("sq_NhaCungCap_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@Ten", Data.Ten));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", Data.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@SDT", Data.SDT));
                cmd.Parameters.Add(new SqlParameter("@Email", Data.Email));
                cmd.Parameters.Add(new SqlParameter("@Fax", Data.Fax));
                cmd.Parameters.Add(new SqlParameter("@SoTK", Data.SoTK));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[NhaCungCap_Update]
        public void NhaCungCap_Update(NhaCungCapInfo Data)
        {
            using (var cmd = new SqlCommand("sq_NhaCungCap_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@Ten", Data.Ten));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", Data.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@SDT", Data.SDT));
                cmd.Parameters.Add(new SqlParameter("@Email", Data.Email));
                cmd.Parameters.Add(new SqlParameter("@SoTK", Data.SoTK));
                cmd.Parameters.Add(new SqlParameter("@Fax", Data.Fax));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[NhaCungCap_Delete]
        public void NhaCungCap_Delete(NhaCungCapInfo Data)
        {
            using (var cmd = new SqlCommand("sq_NhaCungCap_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[NhaCungCap_Kiemtra]
        public int NhaCungCap_Kiemtra(string MaNhaCungCap)
        {
            SqlCommand cmd = new SqlCommand("sq_NhaCungCap_KiemTra", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNhaCungCap", MaNhaCungCap));
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