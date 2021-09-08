using SamLop.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SamLop.Business
{
    public class NhaSanXuatService
    {

        private static readonly NhaSanXuatDAL db = new NhaSanXuatDAL();
        #region[NhaSanXuat_Kiemtra]
        public static int NhaSanXuat_Kiemtra(string TenKhuVuc)
        {
            return db.NhaSanXuat_Kiemtra(TenKhuVuc);
        }
        #endregion
        #region[NhaSanXuat_GetById]
        public static DataTable NhaSanXuat_GetById(NhaSanXuatInfo Data)
        {
            return db.NhaSanXuat_GetById(Data);
        }
        #endregion
        #region[NhaSanXuat_GetByAll]
        public static DataTable NhaSanXuat_GetByAll()
        {
            return db.NhaSanXuat_GetByAll();
        }
        #endregion
        #region[NhaSanXuat_GetByTop]
        public static DataTable NhaSanXuat_GetByTop(string Top, string Where, string Order)
        {
            return db.NhaSanXuat_GetByTop(Top, Where, Order);
        }
        #endregion
        #region[NhaSanXuat_Insert]
        public static void NhaSanXuat_Insert(NhaSanXuatInfo Data)
        {
            db.NhaSanXuat_Insert(Data);
        }
        #endregion
        #region[NhaSanXuat_Update]
        public static void NhaSanXuat_Update(NhaSanXuatInfo Data)
        {
            db.NhaSanXuat_Update(Data);
        }
        #endregion
        #region[NhaSanXuat_Delete]
        public static void NhaSanXuat_Delete(NhaSanXuatInfo data)
        {
            db.NhaSanXuat_Delete(data);
        }
        #endregion
    }
}