using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project1
{
    public static class CartData
    {
        // ListViewItem을 저장할 정적 리스트.
        // 프로그램이 종료될 때까지 데이터가 유지됩니다.
        public static List<ListViewItem> CartItems { get; set; } = new List<ListViewItem>();
    }
}
