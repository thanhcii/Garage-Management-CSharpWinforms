using SamLop.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SamLop.Business
{
    public class ChiTietBaoTriService
    {

        private static readonly ChiTietBaoTriDAL db = new ChiTietBaoTriDAL();
        #region[ChiTietBaoTri_GetById]
        public static DataTable ChiTietBaoTri_GetById(ChiTietBaoTriInfo Data)
        {
            return db.ChiTietBaoTri_GetById(Data);
        }
        #endregion
        #region[Chitiethoadonbaotri_GetByAll]
        public static DataTable Chitiethoadonbaotri_GetByAll()
        {
            return db.Chitiethoadonbaotri_GetByAll();
        }
        #endregion
        #region[Doanhthuthucte_GetByAll]
        public static DataTable Doanhthuthucte_GetByAll()
        {
            return db.Doanhthuthucte_GetByAll();
        }
        #endregion
        #region[Chitietnonhacungcap_GetByAll]
        public static DataTable Chitietnonhacungcap_GetByAll()
        {
            return db.Chitietnonhacungcap_GetByAll();
        }
        #endregion
        #region[Chitietthanhtoanno_GetByAll]
        public static DataTable Chitietthanhtoanno_GetByAll()
        {
            return db.Chitietthanhtoanno_GetByAll();
        }
        #endregion
        #region[Bangnokhachhang_GetByAll]
        public static DataTable Bangnokhachhang_GetByAll()
        {
            return db.Bangnokhachhang_GetByAll();
        }
        #endregion
        #region[ChiTietBaoTri_GetByAll]
        public static DataTable ChiTietBaoTri_GetByAll()
        {
            return db.ChiTietBaoTri_GetByAll();
        }
        #endregion
        #region[CHIETXEBAOTRI_GetByTop]
        public static DataTable CHIETXEBAOTRI_GetByTop(string Top, string Where, string Order)
        {
            return db.CHIETXEBAOTRI_GetByTop(Top, Where, Order);
        }
        #endregion
        #region[Bangnokhachhang_GetByTop]
        public static DataTable Bangnokhachhang_GetByTop(string Top, string Where, string Order)
        {
            return db.Bangnokhachhang_GetByTop(Top, Where, Order);
        }
        #endregion
        #region[XUATHANGTATTANTAT_GetByTop]
        public static DataTable XUATHANGTATTANTAT_GetByTop(string Top, string Where, string Order)
        {
            return db.XUATHANGTATTANTAT_GetByTop(Top, Where, Order);
        }
        #endregion
        #region[TATTANTATVENHAPHANG_GetByTop]
        public static DataTable TATTANTATVENHAPHANG_GetByTop(string Top, string Where, string Order)
        {
            return db.TATTANTATVENHAPHANG_GetByTop(Top, Where, Order);
        }
        #endregion


        #region[ChiTietBaoTri_GetByTop]
        public static DataTable ChiTietBaoTri_GetByTop(string Top, string Where, string Order)
        {
            return db.ChiTietBaoTri_GetByTop(Top, Where, Order);
        }
        #endregion
        #region[ChiTietBaoTri_Insert]
        public static void ChiTietBaoTri_Insert(ChiTietBaoTriInfo Data)
        {
            db.ChiTietBaoTri_Insert(Data);
        }
        #endregion
        #region[ChiTietBaoTri_Update]
        public static void ChiTietBaoTri_Update(ChiTietBaoTriInfo Data)
        {
            db.ChiTietBaoTri_Update(Data);
        }
        #endregion
        #region[ChiTietBaoTri_Delete]
        public static void ChiTietBaoTri_Delete(ChiTietBaoTriInfo data)
        {
            db.ChiTietBaoTri_Delete(data);
        }
        #endregion
        #region[ChiTietBaoTri_Sum]
        public static DataTable ChiTietBaoTri_Sum(ChiTietBaoTriInfo Data)
        {
            return db.ChiTietBaoTri_Sum(Data);
        }
        #endregion
    }
}