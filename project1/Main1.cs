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
    public partial class Main1 : Form
    {
        public Main1()
        {
            InitializeComponent();
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            // 1. 현재 창(Main1)을 숨깁니다.
            this.Hide();

            // 2. Login 창의 새 인스턴스를 생성합니다.
            Login loginForm = new Login();

            // 3. Login 창을 엽니다. ShowDialog()는 이 창이 닫힐 때까지 다른 창을 제어할 수 없게 합니다.
            loginForm.ShowDialog();

            // 4. Login 창이 닫히고 나면, 숨겨두었던 Main1 창을 마저 닫아 프로그램을 종료합니다.
            this.Close();
        }

        private void btnResistar_Click(object sender, EventArgs e)
        {
            // 1. 현재 창(Main1)을 숨깁니다.
            this.Hide();

            // 2. Login 창의 새 인스턴스를 생성합니다.
            Resister resisterForm = new Resister();

            // 3. Login 창을 엽니다. ShowDialog()는 이 창이 닫힐 때까지 다른 창을 제어할 수 없게 합니다.
            resisterForm.ShowDialog();

            // 4. Login 창이 닫히고 나면, 숨겨두었던 Main1 창을 마저 닫아 프로그램을 종료합니다.
            this.Close();
        }

        private void Main1_Load(object sender, EventArgs e)
        {
            try
            {
                //
                pictureBox1.Image = Image.FromFile(@"C:\가구 누끼\main1.gif");
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("이미지 파일을 찾을 수 없습니다. 경로를 확인해주세요.");
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            string text = "가구 주문\n키오스크";

            // 폰트와 브러시(색상) 설정
            Font font = new Font("Cafe24 Ssurround", 30, FontStyle.Bold); // 폰트 이름은 시스템에 설치된 정확한 이름으로 사용해야 합니다.
            Brush brush = Brushes.White;

            // 텍스트 정렬을 위한 StringFormat 생성
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;      // 수평 가운데 정렬
            stringFormat.LineAlignment = StringAlignment.Center;  // 수직 가운데 정렬

            // PictureBox의 전체 영역을 가져옴
            RectangleF drawArea = (sender as PictureBox).ClientRectangle;

            // 수정된 DrawString 메서드 호출
            e.Graphics.DrawString(text, font, brush, drawArea, stringFormat);
        }
    }
}
