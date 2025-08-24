using Microsoft.VisualBasic;
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
    public partial class Drawer : Form
    {
        public Drawer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            string productName = "바게보 도어";
            string description = "수납장은 한정된 공간을 보다 효율적으로 활용할 수 있게 도와주는 필수 가구.\n 천장 가까이까지 높게 설치하면 자투리 공간까지 활용 가능,\n작은 집이나 원룸에서도 깔끔하고 효율적인 생활 환경을 조성";
            string price = "30,000";
            string imagePath = @"C:\가구 누끼\서랍장 누끼\1.png";
            information infoForm = new information(productName, description, price, imagePath);
            infoForm.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string productName = "비할스 다용도";
            string description = "다양한 크기와 깊이의 선반과 서랍으로 구성된 수납장은\n 물건을 체계적으로 정리할 수 있도록 설계되어 있습니다. \n문서, 의류, 식기류, 생활용품 등 각각의 용도에 맞게 나눠 \n보관할 수 있어 찾기 쉬우며 정리정돈 습관을 들이기에 좋습니다.\n";
            string price = "118,000";
            string imagePath = @"C:\가구 누끼\서랍장 누끼\2.png"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string productName = "서랍장 S";
            string description = "수납장은 단순히 물건을 보관하는 용도를 넘어, \n공간의 분위기와 조화를 이루는 인테리어 아이템으로도 \n중요한 역할을 합니다. 나무, 금속, 유리 등 다양한 재질과 색상,\n 디자인으로 제작되어, 모던한 느낌부터\n클래식한 분위기까지 연출할 수 있습니다.";
            string price = "194,000";
            string imagePath = @"C:\가구 누끼\서랍장 누끼\3.png"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string productName = "서랍장 D";
            string description = "수납장은 목적에 따라 크기와 형태가 다양하게 제작됩니다.\n 좁은 공간에 적합한 슬림형 수납장부터, \n거실 전체를 감싸는 대형 벽면형 수납장까지\n 선택의 폭이 넓어 사용자의 라이프스타일과 공간 구조에\n 맞게 맞춤형으로 선택할 수 있습니다.";
            string price = "110,000";
            string imagePath = @"C:\가구 누끼\서랍장 누끼\4,png"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string productName = "서랍장 F";
            string description = "바퀴가 달린 이동식 수납장은 필요에 따라 위치를 바꿔가며 \n사용할 수 있어 청소나 공간 재배치 시 매우 유용합니다.\n 주방, 욕실, 서재 등 다양한 장소에서 다목적으로\n 활용될 수 있으며, 유아용 수납장으로도 인기가 많습니다.";
            string price = "99,900";
            string imagePath = @"C:\가구 누끼\서랍장 누끼\5.png"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string productName = "서랍장 G";
            string description = "수납장은 사용자에 따라 맞춤형 설계가 가능합니다.\n 예를 들어 어린이를 위한 낮은 높이의 수납장이나, \n손잡이가 크고 열기 쉬운 구조는 사용의 편의성을 높이며, 노약자들도 \n안전하게 사용할 수 있도록 제작할 수 있습니다.";
            string price = "50,000";
            string imagePath = @"C:\가구 누끼\서랍장 누끼\6.png"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string productName = "서랍장 H";
            string description = "최근에는 환경에 대한 관심이 높아지면서, \n친환경 자재를 사용한 수납장도 많이 출시되고 있습니다. \n포름알데히드 방출이 적은 자재나 재활용 가능한 소재로 \n제작된 제품은 실내 공기질을 개선하고 지속가능한 소비를\n 실천하는 데 도움이 됩니다.";
            string price = "192,000";
            string imagePath = @"C:\가구 누끼\서랍장 누끼\7.png"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            string productName = "서랍장 J";
            string description = "일부 수납장은 모듈형 구조로 되어 있어, 사용자의 필요에\n 따라 선반이나 서랍을 추가하거나 배치를 바꿀 수 있는 유연성이 있습니다.\n 이로 인해 시간이 지나며 라이프스타일이 바뀌더라도\n 새 가구를 사지 않고도 수납 공간을 조절할 수 있는 장점이 있습니다.";
            string price = "60,000";
            string imagePath = @"C:\가구 누끼\서랍장 누끼\8.png"; // 실제 이미지 파일 경로
            this.Close();
            information infoForm = new information(productName, description, price, imagePath);
            infoForm.ShowDialog();
            this.Close();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string productName = "서랍장 K";
            string description = "일부 수납장은 자물쇠나 디지털 락, 비밀번호 잠금장치가 장착되어 있고\n 중요한 서류나 귀중품을 안전하게 보관할 수 있습니다.\n 특히 사무실, 학교, 또는 공유 공간에서 개인\n 소지품을 보호하는 데 유용하며, 가정에서도 \n약이나 문서, 고가의 물건을 안전하게 보관하는 용도로 활용됩니다.\n 최근에는 스마트 기능이 추가된 수납장도 등장해 모바일 앱으로 잠금 상태를 \n확인하거나 원격 제어가 가능한 제품도\n 출시되고 있습니다.";
            string price = "120,000";
            string imagePath = @"C:\가구 누끼\서랍장 누끼\9.png"; // 실제 이미지 파일 경로

            information infoForm = new information(productName, description, price, imagePath);
            infoForm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Funiture funiture = new Funiture();
            funiture.ShowDialog();

            // 4. Login 창이 닫히고 나면, 숨겨두었던 Main1 창을 마저 닫아 프로그램을 종료합니다.
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
