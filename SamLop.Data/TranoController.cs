using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SamLop.Data
{
    public class TranoDAL : SqlDataProvider
    {
        #region[Trano_GetbyAll]
        public DataTable Trano_GetByAll()
        {
            using (var cmd = new SqlCommand("sq_Trano_GetByAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
        #region[Trano_GetbyId]
        public DataTable Trano_GetById(TranoInfo Data)
        {
            using (var cmd = new SqlCommand("sq_Trano_GetById", GetConnection()))
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
        #region[Trano_GetbyTop]
        public DataTable Trano_GetByTop(string Top, string Where, string Order)
        {
            using (var cmd = new SqlCommand("sq_Trano_GetByTop", GetConnection()))
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
        #region[Trano_Insert]
        public void Trano_Insert(TranoInfo Data)
        {
            using (var cmd = new SqlCommand("sq_Trano_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;  
                cmd.Parameters.Add(new SqlParameter("@ID_Thanhtoan", Data.ID_Thanhtoan));
                cmd.Parameters.Add(new SqlParameter("@Thuoctinh", Data.Thuoctinh));
                cmd.Parameters.Add(new SqlParameter("@Ngaytra", Data.Ngaytra));
                cmd.Parameters.Add(new SqlParameter("@ID_Nhanvien", Data.ID_Nhanvien));
                cmd.Parameters.Add(new SqlParameter("@Sotien", Data.Sotien));
                cmd.Parameters.Add(new SqlParameter("@Ghichu", Data.Ghichu));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[Trano_Update]
        public void Trano_Update(TranoInfo Data)
        {
            using (var cmd = new SqlCommand("sq_Trano_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.Parameters.Add(new SqlParameter("@ID_Thanhtoan", Data.ID_Thanhtoan));
                cmd.Parameters.Add(new SqlParameter("@Thuoctinh", Data.Thuoctinh));
                cmd.Parameters.Add(new SqlParameter("@NguoiCapNhat", Data.NguoiCapNhat));
                cmd.Parameters.Add(new SqlParameter("@NgayCapNhat", Data.NgayCapNhat));
                cmd.Parameters.Add(new SqlParameter("@Sotien", Data.Sotien));
                cmd.Parameters.Add(new SqlParameter("@Ghichu", Data.Ghichu));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region[Trano_Delete]
        public void Trano_Delete(TranoInfo Data)
        {
            using (var cmd = new SqlCommand("sq_Trano_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", Data.ID));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        
    }
}