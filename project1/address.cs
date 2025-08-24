using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class address : Form
    {
        Count c1;
        public address()
        {
            InitializeComponent();
        }
        public address(Count c1)
        {
            InitializeComponent();
            this.c1 = c1;
        }

        private void bt_input_Click_Click(object sender, EventArgs e)
        {
            string text = comboBox1.Text + " " + comboBox2.Text + " " + textBox1.Text;
            c1.TextBox1 = text;
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Add("강남구");
                comboBox2.Items.Add("강동구");
                comboBox2.Items.Add("강북구");
                comboBox2.Items.Add("강서구");
                comboBox2.Items.Add("관악구");
                comboBox2.Items.Add("광진구");
                comboBox2.Items.Add("구로구");
                comboBox2.Items.Add("금천구");
                comboBox2.Items.Add("노원구");
                comboBox2.Items.Add("도봉구");
                comboBox2.Items.Add("동대문구");
                comboBox2.Items.Add("동작구");
                comboBox2.Items.Add("마포구");
                comboBox2.Items.Add("서대문구");
                comboBox2.Items.Add("서초구");
                comboBox2.Items.Add("성동구");
                comboBox2.Items.Add("성북구");
                comboBox2.Items.Add("송파구");
                comboBox2.Items.Add("양천구");
                comboBox2.Items.Add("영등포구");
                comboBox2.Items.Add("용산구");
                comboBox2.Items.Add("은평구");
                comboBox2.Items.Add("종로구");
                comboBox2.Items.Add("중구");
                comboBox2.Items.Add("중랑구");
            }

            // 부산광역시 (인덱스 1)를 선택했을 때
            if (comboBox1.SelectedIndex == 1)
            {
                // 요청하신 "가평군"을 먼저 추가합니다.
                comboBox2.Items.Add("가평군");
                // 이어서 부산의 실제 구/군을 추가합니다.
                comboBox2.Items.Add("강서구");
                comboBox2.Items.Add("금정구");
                comboBox2.Items.Add("기장군");
                comboBox2.Items.Add("남구");
                comboBox2.Items.Add("동구");
                comboBox2.Items.Add("동래구");
                comboBox2.Items.Add("부산진구");
                comboBox2.Items.Add("북구");
                comboBox2.Items.Add("사상구");
                comboBox2.Items.Add("사하구");
                comboBox2.Items.Add("서구");
                comboBox2.Items.Add("수영구");
                comboBox2.Items.Add("연제구");
                comboBox2.Items.Add("영도구");
                comboBox2.Items.Add("중구");
                comboBox2.Items.Add("해운대구");
            }

            // 대구광역시 (인덱스 2)를 선택했을 때
            if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Add("군위군");
                comboBox2.Items.Add("남구");
                comboBox2.Items.Add("달서구");
                comboBox2.Items.Add("달성군");
                comboBox2.Items.Add("동구");
                comboBox2.Items.Add("북구");
                comboBox2.Items.Add("서구");
                comboBox2.Items.Add("수성구");
                comboBox2.Items.Add("중구");
            }

            // 인천광역시 (인덱스 3)를 선택했을 때
            if (comboBox1.SelectedIndex == 3)
            {
                comboBox2.Items.Add("강화군");
                comboBox2.Items.Add("계양구");
                comboBox2.Items.Add("남동구");
                comboBox2.Items.Add("동구");
                comboBox2.Items.Add("미추홀구");
                comboBox2.Items.Add("부평구");
                comboBox2.Items.Add("서구");
                comboBox2.Items.Add("연수구");
                comboBox2.Items.Add("옹진군");
                comboBox2.Items.Add("중구");
            }

            // 광주광역시 (인덱스 4)를 선택했을 때
            if (comboBox1.SelectedIndex == 4)
            {
                comboBox2.Items.Add("광산구");
                comboBox2.Items.Add("남구");
                comboBox2.Items.Add("동구");
                comboBox2.Items.Add("북구");
                comboBox2.Items.Add("서구");
            }

            // 대전광역시 (인덱스 5)를 선택했을 때
            if (comboBox1.SelectedIndex == 5)
            {
                comboBox2.Items.Add("대덕구");
                comboBox2.Items.Add("동구");
                comboBox2.Items.Add("서구");
                comboBox2.Items.Add("유성구");
                comboBox2.Items.Add("중구");
            }

            // 울산광역시 (인덱스 6)를 선택했을 때
            if (comboBox1.SelectedIndex == 6)
            {
                comboBox2.Items.Add("남구");
                comboBox2.Items.Add("동구");
                comboBox2.Items.Add("북구");
                comboBox2.Items.Add("울주군");
                comboBox2.Items.Add("중구");
            }
        }
    }
}
