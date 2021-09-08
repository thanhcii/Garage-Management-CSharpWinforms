using SamLop.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SamLop.Business
{
    public class NhanVienService
    {

        private static readonly NhanVienDAL db = new NhanVienDAL();
        #region[NhanVien_Kiemtra]
        public static int NhanVien_Kiemtra(string TenKhuVuc)
        {
            return db.NhanVien_Kiemtra(TenKhuVuc);
        }
        #endregion
        #region[NhanVien_GetById]
        public static DataTable NhanVien_GetById(NhanVienInfo Data)
        {
            return db.NhanVien_GetById(Data);
        }
        #endregion
        #region[NhanVien_GetByAll]
        public static DataTable NhanVien_GetByAll()
        {
            return db.NhanVien_GetByAll();
        }
        #endregion
        #region[NhanVien_GetByTop]
        public static DataTable NhanVien_GetByTop(string Top, string Where, string Order)
        {
            return db.NhanVien_GetByTop(Top, Where, Order);
        }
        #endregion
        #region[NhanVien_Insert]
        public static void NhanVien_Insert(NhanVienInfo Data)
        {
            db.NhanVien_Insert(Data);
        }
        #endregion
        #region[NhanVien_Update]
        public static void NhanVien_Update(NhanVienInfo Data)
        {
            db.NhanVien_Update(Data);
        }
        #endregion
        #region[NhanVien_DoiMatKhau]
        public static void NhanVien_DoiMatKhau(NhanVienInfo Data)
        {
            db.NhanVien_DoiMatKhau(Data);
        }
        #endregion
        #region[NhanVien_Delete]
        public static void NhanVien_Delete(NhanVienInfo data)
        {
            db.NhanVien_Delete(data);
        }
        #endregion
        #region[NhanVien_Doithongtincanhan]
        public static void NhanVien_Doithongtincanhan(NhanVienInfo data)
        {
            db.NhanVien_Doithongtincanhan(data);
        }
        #endregion
    }
}