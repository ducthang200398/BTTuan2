using System.Collections.Generic;

namespace GroupView
{
    public class LoaiHoa:List<hoa>
    {
        public string TenLoai { get; set; }
        private LoaiHoa(string tenloai)
        {
            TenLoai = tenloai;
        }
        public IList<LoaiHoa> Loaihoas { get; set; }
        public LoaiHoa()
        {
            List<LoaiHoa> l = new List<LoaiHoa>
            {
                new LoaiHoa("Hoa Cuc")
                {

                 new hoa { TenHoa = "Đón Xuân", Gia =50000,Hinh ="hoacuc.jpg",Mota="Hoa cuc cac mau:trắng ,vàng , cam"},
                 new hoa { TenHoa = "Hồn Nhiên", Gia = 60000, Hinh = "hoacucdai.jpg", Mota = "Hoa cuc vàng , cam, lá nắng" },
                new hoa { TenHoa = "Tím thủy chung", Gia = 45000, Hinh = "hoacuctim.jpg", Mota = "Hoa cuc tím" }
                },
                 new LoaiHoa("Hoa Cuoi")
                {

                 new hoa { TenHoa = "Dây tơ hồng", Gia =50000,Hinh ="hoahong.jpg",Mota="Hoa cúc các màu : trắng,vàng,cam"},
                 new hoa { TenHoa = "Hoa hồng trắng", Gia = 60000, Hinh = "hoahongtrang.jpg", Mota = "Hoa cuc vàng , cam, lá mắng" },
                new hoa { TenHoa = "Cầy thuỷ tinh", Gia = 45000, Hinh = "hoathuytien.jpg", Mota = "Hoa thủy tiên và các loại hoa dại khác" }
                }

            };
            Loaihoas = l;


        }

        
    }
}