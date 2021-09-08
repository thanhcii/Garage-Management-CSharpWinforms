using SamLop.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SamLop.Business
{
    public class HoaDonNhapService
    {

        private static readonly HoaDonNhapDAL db = new HoaDonNhapDAL();
        #region[HoaDonNhap_Kiemtra]
        public static int HoaDonNhap_Kiemtra(string TenKhuVuc)
        {
            return db.HoaDonNhap_Kiemtra(TenKhuVuc);
        }
        #endregion
        #region[HoaDonNhap_GetById]
        public static DataTable HoaDonNhap_GetById(HoaDonNhapInfo Data)
        {
            return db.HoaDonNhap_GetById(Data);
        }
        #endregion
        #region[HoaDonNhap_GetByAll]
        public static DataTable HoaDonNhap_GetByAll()
        {
            return db.HoaDonNhap_GetByAll();
        }
        #endregion
        #region[Baocaonhap_GetByTop]
        public static DataTable Baocaonhap_GetByTop(string Where)
        {
            return db.Baocaonhap_GetByTop(Where);
        }
        #endregion
        #region[HoaDonNhap_GetByTop]
        public static DataTable HoaDonNhap_GetByTop(string Top, string Where, string Order)
        {
            return db.HoaDonNhap_GetByTop(Top, Where, Order);
        }
        #endregion
        #region[HoaDonNhap_Insert]
        public static void HoaDonNhap_Insert(HoaDonNhapInfo Data)
        {
            db.HoaDonNhap_Insert(Data);
        }
        #endregion
        #region[HoaDonNhap_Update]
        public static void HoaDonNhap_Update(HoaDonNhapInfo Data)
        {
            db.HoaDonNhap_Update(Data);
        }
        #endregion
        #region[HoaDonNhap_Tien]
        public static void HoaDonNhap_Tien(HoaDonNhapInfo Data)
        {
            db.HoaDonNhap_Tien(Data);
        }
        #endregion
        #region[HoaDonNhap_Delete]
        public static void HoaDonNhap_Delete(HoaDonNhapInfo data)
        {
            db.HoaDonNhap_Delete(data);
        }
        #endregion
    }
}