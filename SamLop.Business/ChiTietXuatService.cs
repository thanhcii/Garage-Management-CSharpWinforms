using SamLop.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SamLop.Business
{
    public class ChiTietXuatService
    {

        private static readonly ChiTietXuatDAL db = new ChiTietXuatDAL();
        #region[ChiTietXuat_Kiemtra]
        public static int ChiTietXuat_Kiemtra(string TenKhuVuc)
        {
            return db.ChiTietXuat_Kiemtra(TenKhuVuc);
        }
        #endregion
        #region[ChiTietXuat_GetById]
        public static DataTable ChiTietXuat_GetById(ChiTietXuatInfo Data)
        {
            return db.ChiTietXuat_GetById(Data);
        }
        #endregion
        #region[ChiTietXuat_GetByAll]
        public static DataTable ChiTietXuat_GetByAll()
        {
            return db.ChiTietXuat_GetByAll();
        }
        #endregion
        #region[Chitiethoadonxuat_GetByAll]
        public static DataTable Chitiethoadonxuat_GetByAll()
        {
            return db.Chitiethoadonxuat_GetByAll();
        }
        #endregion
        #region[ChiTietXuat_GetByTop]
        public static DataTable ChiTietXuat_GetByTop(string Top, string Where, string Order)
        {
            return db.ChiTietXuat_GetByTop(Top, Where, Order);
        }
        #endregion
        #region[ChiTietXuat_Insert]
        public static void ChiTietXuat_Insert(ChiTietXuatInfo Data)
        {
            db.ChiTietXuat_Insert(Data);
        }
        #endregion
        #region[ChiTietXuat_Update]
        public static void ChiTietXuat_Update(ChiTietXuatInfo Data)
        {
            db.ChiTietXuat_Update(Data);
        }
        #endregion
        #region[ChiTietXuat_Delete]
        public static void ChiTietXuat_Delete(ChiTietXuatInfo data)
        {
            db.ChiTietXuat_Delete(data);
        }
        #endregion
        #region[ChiTietXuat_Sum]
        public static DataTable ChiTietXuat_Sum(ChiTietXuatInfo Data)
        {
            return db.ChiTietXuat_Sum(Data);
        }
        #endregion
    }
}