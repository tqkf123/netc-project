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
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productName = "책상A";
            string description = "심플한 디자인의 서랍장입니다.";
            string price = "30,000";
            string imagePath = @"C:\가구 누끼\책상 누끼\1.png"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string productName = "책상 B";
            string description = "심플한 디자인의 서랍장입니다.";
            string price = "40,000";
            string imagePath = @"C:\가구 누끼\책상 누끼\2.png"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string productName = "책상 C";
            string description = "심플한 디자인의 서랍장입니다.";
            string price = "50,000";
            string imagePath = @"C:\가구 누끼\책상 누끼\3.png"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string productName = "책상 D";
            string description = "심플한 디자인의 서랍장입니다.";
            string price = "60,000";
            string imagePath = @"C:\가구 누끼\책상 누끼\4.png"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string productName = "책상 E";
            string description = "심플한 디자인의 서랍장입니다.";
            string price = "70,000";
            string imagePath = @"C:\가구 누끼\책상 누끼\5.png"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string productName = "책상 F";
            string description = "심플한 디자인의 서랍장입니다.";
            string price = "80,000";
            string imagePath = @"C:\가구 누끼\책상 누끼\6.png"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string productName = "책상 G";
            string description = "심플한 디자인의 서랍장입니다.";
            string price = "90,000";
            string imagePath = @"C:\가구 누끼\책상 누끼\7.png"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string productName = "책상 H";
            string description = "심플한 디자인의 서랍장입니다.";
            string price = "100,000";
            string imagePath = @"C:\가구 누끼\책상 누끼\8.png"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string productName = "책상 I";
            string description = "심플한 디자인의 서랍장입니다.";
            string price = "110,000";
            string imagePath = @"C:\가구 누끼\책상 누끼\9.png"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void Table_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.ShowDialog();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Blankit blankit = new Blankit();
            blankit.ShowDialog();
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
