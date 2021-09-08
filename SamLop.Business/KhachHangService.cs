using SamLop.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SamLop.Business
{
    public class KhachHangService
    {

        private static readonly KhachHangDAL db = new KhachHangDAL();
        #region[KhachHang_Kiemtra]
        public static int KhachHang_Kiemtra(string TenKhuVuc)
        {
            return db.KhachHang_Kiemtra(TenKhuVuc);
        }
        #endregion
        #region[KhachHang_GetById]
        public static DataTable KhachHang_GetById(KhachHangInfo Data)
        {
            return db.KhachHang_GetById(Data);
        }
        #endregion
        #region[KhachHang_GetByAll]
        public static DataTable KhachHang_GetByAll()
        {
            return db.KhachHang_GetByAll();
        }
        #endregion
        #region[KhachHang_GetByTop]
        public static DataTable KhachHang_GetByTop(string Top, string Where, string Order)
        {
            return db.KhachHang_GetByTop(Top, Where, Order);
        }
        #endregion
        #region[KhachHang_Insert]
        public static void KhachHang_Insert(KhachHangInfo Data)
        {
            db.KhachHang_Insert(Data);
        }
        #endregion
        #region[KhachHang_Update]
        public static void KhachHang_Update(KhachHangInfo Data)
        {
            db.KhachHang_Update(Data);
        }
        #endregion
        #region[KhachHang_Delete]
        public static void KhachHang_Delete(KhachHangInfo data)
        {
            db.KhachHang_Delete(data);
        }
        #endregion
    }
}