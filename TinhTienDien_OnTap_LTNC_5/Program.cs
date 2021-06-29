using System;
using System.Collections.Generic;
using System.Text;
namespace TinhTienDien_OnTap_LTNC_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            TinhTienDien t = new TinhTienDien();
            t.nhapTT();
            t.xuatTT();

        }
    }
}
