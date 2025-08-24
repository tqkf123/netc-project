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
    public partial class Interial : Form
    {
        public Interial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productName = "서랍장 A";
            string description = "심플한 디자인의 서랍장입니다.";
            string price = "100,000";
            string imagePath = "Resources/drawer_a.jpg"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string productName = "서랍장 A";
            string description = "심플한 디자인의 서랍장입니다.";
            string price = "100,000";
            string imagePath = "Resources/drawer_a.jpg"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string productName = "서랍장 A";
            string description = "심플한 디자인의 서랍장입니다.";
            string price = "100,000";
            string imagePath = "Resources/drawer_a.jpg"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string productName = "서랍장 A";
            string description = "심플한 디자인의 서랍장입니다.";
            string price = "100,000";
            string imagePath = "Resources/drawer_a.jpg"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string productName = "서랍장 A";
            string description = "심플한 디자인의 서랍장입니다.";
            string price = "100,000";
            string imagePath = "Resources/drawer_a.jpg"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string productName = "서랍장 A";
            string description = "심플한 디자인의 서랍장입니다.";
            string price = "100,000";
            string imagePath = "Resources/drawer_a.jpg"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string productName = "서랍장 A";
            string description = "심플한 디자인의 서랍장입니다.";
            string price = "100,000";
            string imagePath = "Resources/drawer_a.jpg"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string productName = "서랍장 A";
            string description = "심플한 디자인의 서랍장입니다.";
            string price = "100,000";
            string imagePath = "Resources/drawer_a.jpg"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string productName = "서랍장 A";
            string description = "심플한 디자인의 서랍장입니다.";
            string price = "100,000";
            string imagePath = "Resources/drawer_a.jpg"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
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
