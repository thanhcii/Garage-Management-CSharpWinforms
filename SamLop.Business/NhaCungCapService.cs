using SamLop.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SamLop.Business
{
    public class NhaCungCapService
    {

        private static readonly NhaCungCapDAL db = new NhaCungCapDAL();
        #region[NhaCungCap_Kiemtra]
        public static int NhaCungCap_Kiemtra(string TenKhuVuc)
        {
            return db.NhaCungCap_Kiemtra(TenKhuVuc);
        }
        #endregion
        #region[NhaCungCap_GetById]
        public static DataTable NhaCungCap_GetById(NhaCungCapInfo Data)
        {
            return db.NhaCungCap_GetById(Data);
        }
        #endregion
        #region[NhaCungCap_GetByAll]
        public static DataTable NhaCungCap_GetByAll()
        {
            return db.NhaCungCap_GetByAll();
        }
        #endregion
        #region[NhaCungCap_GetByTop]
        public static DataTable NhaCungCap_GetByTop(string Top, string Where, string Order)
        {
            return db.NhaCungCap_GetByTop(Top, Where, Order);
        }
        #endregion
        #region[NhaCungCap_Insert]
        public static void NhaCungCap_Insert(NhaCungCapInfo Data)
        {
            db.NhaCungCap_Insert(Data);
        }
        #endregion
        #region[NhaCungCap_Update]
        public static void NhaCungCap_Update(NhaCungCapInfo Data)
        {
            db.NhaCungCap_Update(Data);
        }
        #endregion
        #region[NhaCungCap_Delete]
        public static void NhaCungCap_Delete(NhaCungCapInfo data)
        {
            db.NhaCungCap_Delete(data);
        }
        #endregion
    }
}