using System;
using System.Collections.Generic;
using System.Text;

namespace TinhTienDien_OnTap_LTNC_5
{
    class TinhTienDien
    {
        private string _tenChuHo, _maSoCongTo;
        int _chiSoCu, _chiSoMoi;
        public static double DM = 50;
        public static double DGTDDM = 1000.536;
        public TinhTienDien()
        {
            _tenChuHo = "";
            _maSoCongTo = "";
            _chiSoCu = 0;
            _chiSoMoi = 0;
        }
        public string TenChuHo
        {
            get => _tenChuHo;
            set => _tenChuHo = value;
        }
        public string MaSoCongTo
        {
            get => _maSoCongTo;
            set => _maSoCongTo = value;
        }
        public int ChiSoCu
        {
            get => _chiSoCu;
            set => _chiSoCu = value;
        }
        public int ChiSoMoi
        {
            get => _chiSoMoi;
            set => _chiSoMoi = value;
        }
        public int SoDienSuDung
        {
            get => _chiSoMoi - _chiSoCu;
        }
        public double TienDien
        {
            get
            {
                if (SoDienSuDung < DM)
                    return Math.Round(SoDienSuDung * DGTDDM);
                else
                    return Math.Round(SoDienSuDung * (1.5 * DGTDDM));
            }
        }
        public void nhapTT()
        {
            Console.WriteLine("****Nhập thông tin tiền điện****");
            Console.Write("Nhập họ tên chủ hộ: ");
            TenChuHo = Console.ReadLine();
            Console.Write("Nhập mã số công tơ điện: ");
            MaSoCongTo = Console.ReadLine();
            Console.Write("Nhập chỉ số cũ: ");
            ChiSoCu = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập chỉ số mới: ");
            ChiSoMoi = Convert.ToInt32(Console.ReadLine());
        }
        public void xuatTT()
        {
            Console.WriteLine("****Thông tin tiền điện****");
            Console.WriteLine($"Họ tên chủ hộ: {TenChuHo}");
            Console.WriteLine($"Nhập mã số công tơ điện: {MaSoCongTo}");
            Console.WriteLine($"Chỉ số cũ: {ChiSoCu}");
            Console.WriteLine($"Chỉ số mới: {ChiSoMoi}");
            Console.WriteLine($"Tổng thanh toán tiền điện: {TienDien} VND");
        }
    }
}
