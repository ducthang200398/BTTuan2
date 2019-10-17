using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListView
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        ObservableCollection<hoa> Hoas = new ObservableCollection<hoa>();
        public MainPage()
        {
            InitializeComponent();
            Hoas.Add(new hoa { TenHoa = "Đón Xuân", Gia =50000,Hinh ="cuc_9.jpg",Mota="Hoa cuc cac mau:trắng ,vàng , cam"});
            Hoas.Add(new hoa { TenHoa = "Hồn Nhiên", Gia = 60000, Hinh = "cuc_2.jpg", Mota = "Hoa cuc vàng , cam, lá nắng" });
            Hoas.Add(new hoa { TenHoa = "Tím thủy chung", Gia = 45000, Hinh = "cuc_3.jpg", Mota = "Hoa cuc tím" });
            lsvHoa.ItemsSource = Hoas;
            

        }

    }
}
