using SamLop.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SamLop.Business
{
    public class HoaDonBaoTriService
    {

        private static readonly HoaDonBaoTriDAL db = new HoaDonBaoTriDAL();
        #region[HoaDonBaoTri_Kiemtra]
        public static int HoaDonBaoTri_Kiemtra(string TenKhuVuc)
        {
            return db.HoaDonBaoTri_Kiemtra(TenKhuVuc);
        }
        #endregion
        #region[HoaDonBaoTri_GetById]
        public static DataTable HoaDonBaoTri_GetById(HoaDonBaoTriInfo Data)
        {
            return db.HoaDonBaoTri_GetById(Data);
        }
        #endregion
        #region[HoaDonBaoTri_GetByAll]
        public static DataTable HoaDonBaoTri_GetByAll()
        {
            return db.HoaDonBaoTri_GetByAll();
        }
        #endregion
        #region[V_HOADONBAOTRI_GetByAll]
        public static DataTable V_HOADONBAOTRI_GetByAll()
        {
            return db.V_HOADONBAOTRI_GetByAll();
        }
        #endregion
        #region[V_HOADONBAOTRI_GetByTop]
        public static DataTable V_HOADONBAOTRI_GetByTop(string Top, string Where, string Order)
        {
            return db.V_HOADONBAOTRI_GetByTop(Top, Where, Order);
        }
        #endregion
        #region[HoaDonBaoTri_GetByTop]
        public static DataTable HoaDonBaoTri_GetByTop(string Top, string Where, string Order)
        {
            return db.HoaDonBaoTri_GetByTop(Top, Where, Order);
        }
        #endregion
        #region[HoaDonBaoTri_Insert]
        public static void HoaDonBaoTri_Insert(HoaDonBaoTriInfo Data)
        {
            db.HoaDonBaoTri_Insert(Data);
        }
        #endregion
        #region[HoaDonBaoTri_Update]
        public static void HoaDonBaoTri_Update(HoaDonBaoTriInfo Data)
        {
            db.HoaDonBaoTri_Update(Data);
        }
        #endregion
        #region[HoaDonBaoTri_Tien]
        public static void HoaDonBaoTri_Tien(HoaDonBaoTriInfo Data)
        {
            db.HoaDonBaoTri_Tien(Data);
        }
        #endregion

        #region[HoaDonBaoTri_Delete]
        public static void HoaDonBaoTri_Delete(HoaDonBaoTriInfo data)
        {
            db.HoaDonBaoTri_Delete(data);
        }
        #endregion
    }
}
