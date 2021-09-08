using SamLop.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SamLop.Business
{
    public class HoaDonXuatService
    {

        private static readonly HoaDonXuatDAL db = new HoaDonXuatDAL();
        #region[HoaDonXuat_Kiemtra]
        public static int HoaDonXuat_Kiemtra(string TenKhuVuc)
        {
            return db.HoaDonXuat_Kiemtra(TenKhuVuc);
        }
        #endregion
        #region[HoaDonXuat_GetById]
        public static DataTable HoaDonXuat_GetById(HoaDonXuatInfo Data)
        {
            return db.HoaDonXuat_GetById(Data);
        }
        #endregion
        #region[HoaDonXuat_GetByAll]
        public static DataTable HoaDonXuat_GetByAll()
        {
            return db.HoaDonXuat_GetByAll();
        }
        #endregion
        #region[BAOCAOXUAT_GetByTop]
        public static DataTable BAOCAOXUAT_GetByTop(string Top, string Where, string Order)
        {
            return db.BAOCAOXUAT_GetByTop(Top, Where, Order);
        }
        #endregion
        #region[HoaDonXuat_GetByTop]
        public static DataTable HoaDonXuat_GetByTop(string Top, string Where, string Order)
        {
            return db.HoaDonXuat_GetByTop(Top, Where, Order);
        }
        #endregion
        #region[HoaDonXuat_Insert]
        public static void HoaDonXuat_Insert(HoaDonXuatInfo Data)
        {
            db.HoaDonXuat_Insert(Data);
        }
        #endregion
        #region[HoaDonXuat_Update]
        public static void HoaDonXuat_Update(HoaDonXuatInfo Data)
        {
            db.HoaDonXuat_Update(Data);
        }
        #endregion
        #region[HoaDonXuat_Tien]
        public static void HoaDonXuat_Tien(HoaDonXuatInfo Data)
        {
            db.HoaDonXuat_Tien(Data);
        }
        #endregion
        #region[HoaDonXuat_Delete]
        public static void HoaDonXuat_Delete(HoaDonXuatInfo data)
        {
            db.HoaDonXuat_Delete(data);
        }
        #endregion
    }
}
