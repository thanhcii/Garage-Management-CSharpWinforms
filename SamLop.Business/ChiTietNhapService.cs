using SamLop.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SamLop.Business
{
    public class ChiTietNhapService
    {

        private static readonly ChiTietNhapDAL db = new ChiTietNhapDAL();
        #region[ChiTietNhap_GetById]
        public static DataTable ChiTietNhap_GetById(ChiTietNhapInfo Data)
        {
            return db.ChiTietNhap_GetById(Data);
        }
        #endregion
        #region[ChiTietNhap_GetByAll]
        public static DataTable ChiTietNhap_GetByAll()
        {
            return db.ChiTietNhap_GetByAll();
        }
        #endregion
        #region[Chitiethoadonnhap_GetByAll]
        public static DataTable Chitiethoadonnhap_GetByAll()
        {
            return db.Chitiethoadonnhap_GetByAll();
        }
        #endregion
        #region[ChiTietNhap_Sum]
        public static DataTable ChiTietNhap_Sum(ChiTietNhapInfo Data)
        {
            return db.ChiTietNhap_Sum(Data);
        }
        #endregion
        #region[ChiTietNhap_GetByTop]
        public static DataTable ChiTietNhap_GetByTop(string Top, string Where, string Order)
        {
            return db.ChiTietNhap_GetByTop(Top, Where, Order);
        }
        #endregion
        #region[Chitiethoadonnhap_GetByTop]
        public static DataTable Chitiethoadonnhap_GetByTop(string Where)
        {
            return Chitiethoadonnhap_GetByTop(Where);
        }
        #endregion
        #region[ChiTietNhap_Insert]
        public static void ChiTietNhap_Insert(ChiTietNhapInfo Data)
        {
            db.ChiTietNhap_Insert(Data);
        }
        #endregion
        #region[ChiTietNhap_Update]
        public static void ChiTietNhap_Update(ChiTietNhapInfo Data)
        {
            db.ChiTietNhap_Update(Data);
        }
        #endregion
        #region[ChiTietNhap_Delete]
        public static void ChiTietNhap_Delete(ChiTietNhapInfo data)
        {
            db.ChiTietNhap_Delete(data);
        }
        #endregion
    }
}