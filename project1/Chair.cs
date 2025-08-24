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
    public partial class Chair : Form
    {
        public Chair()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productName = "리바트";
            string description = "감각적인 컬러와 디자인으로\n공간에 포인트를 더해줍니다.";
            string price = "100,000";
            string imagePath = @"C:\가구 누끼\의자 누끼\1.png";
            information infoForm = new information(productName, description, price, imagePath);
            infoForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productName = "한샘";
            string description = "회전과 높이 조절이 가능해\n체형에 맞는 자세를 유지할 수 있습니다.";
            string price = "70,000";
            string imagePath = @"C:\가구 누끼\의자 누끼\2.png";
            information infoForm = new information(productName, description, price, imagePath);
            infoForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productName = "이케아";
            string description = "접이식 기능을 갖춰\n보관이 간편하고 공간을 절약합니다.";
            string price = "40,000";
            string imagePath = @"C:\가구 누끼\의자 누끼\3.png";
            information infoForm = new information(productName, description, price, imagePath);
            infoForm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productName = "시디즈";
            string description = "편안한 착석감을 제공하는 의자입니다.\n오랜 시간 사용해도 피로감이 적습니다.";
            string price = "120,000";
            string imagePath = @"C:\가구 누끼\의자 누끼\4.png";
            information infoForm = new information(productName, description, price, imagePath);
            infoForm.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productName = "듀오백";
            string description = "공간 활용도가 뛰어난 제품입니다.\n작은 공간에도 효율적으로 배치할 수 있습니다.";
            string price = "100,000";
            string imagePath = @"C:\가구 누끼\의자 누끼\5.png";
            information infoForm = new information(productName, description, price, imagePath);
            infoForm.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productName = "린백";
            string description = "심플한 디자인으로\n어떤 인테리어에도 자연스럽게 어울립니다.";
            string price = "100,000";
            string imagePath = @"C:\가구 누끼\의자 누끼\6.png";
            information infoForm = new information(productName, description, price, imagePath);
            infoForm.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productName = "호매틱";
            string description = "가벼운 무게와 이동성으로\n필요한 곳 어디든 쉽게 옮길 수 있습니다.";
            string price = "100,000";
            string imagePath = @"C:\가구 누끼\의자 누끼\7.png";
            information infoForm = new information(productName, description, price, imagePath);
            infoForm.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productName = "린스틱";
            string description = "튼튼한 소재로 제작되어\n장기간 사용에도 안정적입니다.";
            string price = "100,000";
            string imagePath = @"C:\가구 누끼\의자 누끼\8.png";
            information infoForm = new information(productName, description, price, imagePath);
            infoForm.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            string productName = "하베토";
            string description = "다양한 용도로 활용 가능한\n실용적인 다목적 의자입니다.";
            string price = "100,000";
            string imagePath = @"C:\가구 누끼\의자 누끼\9.png";
            information infoForm = new information(productName, description, price, imagePath);
            infoForm.ShowDialog();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Blankit blankit = new Blankit();
            blankit.ShowDialog();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.ShowDialog();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Funiture funiture = new Funiture();
            funiture.ShowDialog();

            // 4. Login 창이 닫히고 나면, 숨겨두었던 Main1 창을 마저 닫아 프로그램을 종료합니다.
            this.Close();
        }
    }
}
