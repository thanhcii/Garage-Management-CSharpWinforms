using SamLop.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SamLop.Business
{
    public class NhomSPService
    {

        private static readonly NhomSPDAL db = new NhomSPDAL();
        #region[NhomSP_Kiemtra]
        public static int NhomSP_Kiemtra(string TenKhuVuc)
        {
            return db.NhomSP_Kiemtra(TenKhuVuc);
        }
        #endregion
        #region[NhomSP_GetById]
        public static DataTable NhomSP_GetById(NhomSPInfo Data)
        {
            return db.NhomSP_GetById(Data);
        }
        #endregion
        #region[NhomSP_GetByAll]
        public static DataTable NhomSP_GetByAll()
        {
            return db.NhomSP_GetByAll();
        }
        #endregion
        #region[NhomSP_GetByTop]
        public static DataTable NhomSP_GetByTop(string Top, string Where, string Order)
        {
            return db.NhomSP_GetByTop(Top, Where, Order);
        }
        #endregion
        #region[NhomSP_Insert]
        public static void NhomSP_Insert(NhomSPInfo Data)
        {
            db.NhomSP_Insert(Data);
        }
        #endregion
        #region[NhomSP_Update]
        public static void NhomSP_Update(NhomSPInfo Data)
        {
            db.NhomSP_Update(Data);
        }
        #endregion
        #region[NhomSP_Delete]
        public static void NhomSP_Delete(NhomSPInfo data)
        {
            db.NhomSP_Delete(data);
        }
        #endregion
    }
}
