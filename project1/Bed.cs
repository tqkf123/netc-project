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
    public partial class Bed : Form
    {
        public Bed()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productName = "루미에르";
            string description = "편안한 숙면을 위한 인체공학적 설계의 침대입니다.\n몸을 안정적으로 지지해 깊은 잠을 도와줍니다.";
            string price = "130,000";
            string imagePath = @"C:\가구 누끼\침대누끼\1.png";
            information infoForm = new information(productName, description, price, imagePath);
            infoForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productName = "노르딕";
            string description = "수납 기능이 탑재되어 있어\n좁은 공간도 깔끔하게 활용할 수 있습니다.";
            string price = "250,000";
            string imagePath = @"C:\가구 누끼\침대누끼\2.png";
            information infoForm = new information(productName, description, price, imagePath);
            infoForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productName = "클라우드9";
            string description = "심플하고 모던한 디자인으로\n다양한 인테리어 스타일에 잘 어울립니다.";
            string price = "290,000";
            string imagePath = @"C:\가구 누끼\침대누끼\3.png";
            information infoForm = new information(productName, description, price, imagePath);
            infoForm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productName = "벨루토";
            string description = "견고한 프레임 구조로\n장시간 사용해도 뒤틀림 없이 안정적입니다.";
            string price = "230,000";
            string imagePath = @"C:\가구 누끼\침대누끼\4.png";
            information infoForm = new information(productName, description, price, imagePath);
            infoForm.ShowDialog();
            this.Close();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productName = "아르코";
            string description = "고급 매트리스와의 조화로\n지지력과 탄성 모두 우수합니다.";
            string price = "140,000";
            string imagePath = @"C:\가구 누끼\침대누끼\5.png";
            information infoForm = new information(productName, description, price, imagePath);
            infoForm.ShowDialog();
            this.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productName = "모디";
            string description = "조립과 설치가 간편하여\n혼자서도 손쉽게 설치할 수 있습니다.";
            string price = "220,000";
            string imagePath = @"C:\가구 누끼\침대누끼\6.png";
            information infoForm = new information(productName, description, price, imagePath);
            infoForm.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productName = "에덴";
            string description = "헤드보드가 포함되어 있어\n편안한 기대기와 공간 연출이 가능합니다.";
            string price = "270,000";
            string imagePath = @"C:\가구 누끼\침대누끼\7.png";
            information infoForm = new information(productName, description, price, imagePath);
            infoForm.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productName = "세레니티";
            string description = "낮은 높이로 설계되어\n아이부터 어르신까지 안전하게 사용할 수 있습니다.";
            string price = "102,999";
            string imagePath = @"C:\가구 누끼\침대누끼\8.png";
            information infoForm = new information(productName, description, price, imagePath);
            infoForm.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productName = "카멜리아";
            string description = "감각적인 소재와 마감 처리로\n공간에 고급스러운 분위기를 더해줍니다.";
            string price = "110,000";
            string imagePath = @"C:\가구 누끼\침대누끼\9.png";
            information infoForm = new information(productName, description, price, imagePath);
            infoForm.ShowDialog();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Blankit blankit = new Blankit();
            blankit.ShowDialog();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.ShowDialog();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Funiture funiture = new Funiture();
            funiture.ShowDialog();
            this.Close();
        }
    }
}
