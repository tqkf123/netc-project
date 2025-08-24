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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            // 1. 현재 창(Main1)을 숨깁니다.
            this.Hide();

            // 2. Login 창의 새 인스턴스를 생성합니다.
            Main1 mainForm = new Main1();

            // 3. Login 창을 엽니다. ShowDialog()는 이 창이 닫힐 때까지 다른 창을 제어할 수 없게 합니다.
            mainForm.ShowDialog();

            // 4. Login 창이 닫히고 나면, 숨겨두었던 Main1 창을 마저 닫아 프로그램을 종료합니다.
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. 텍스트박스에서 아이디와 비밀번호 가져오기
            string id = textBox1.Text;
            string password = textBox2.Text;

            // 2. 아이디 또는 비밀번호가 비어 있는지 확인
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("아이디와 비밀번호를 모두 입력해주세요.", "로그인 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. 회원가입 데이터(Users)에 아이디가 존재하는지 확인
            // Resister.Users는 static으로 선언되어 있어 바로 접근 가능합니다.
            if (Resister.Users.ContainsKey(id))
            {
                // 4. 아이디가 존재하면, 해당 아이디의 비밀번호가 일치하는지 확인
                User user = Resister.Users[id];
                if (user.Password == password)
                {
                    // 로그인 성공
                    MessageBox.Show($"{user.Id}님, 환영합니다!", "로그인 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 1. 현재 창(Main1)을 숨깁니다.
                    this.Hide();

                    // 2. Login 창의 새 인스턴스를 생성합니다.
                    Search searchForm = new Search();

                    // 3. Login 창을 엽니다. ShowDialog()는 이 창이 닫힐 때까지 다른 창을 제어할 수 없게 합니다.
                    searchForm.ShowDialog();

                    // 4. Login 창이 닫히고 나면, 숨겨두었던 Main1 창을 마저 닫아 프로그램을 종료합니다.
                    this.Close();

                }
                else
                {
                    // 비밀번호가 틀림
                    MessageBox.Show("비밀번호가 올바르지 않습니다.", "로그인 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // 아이디가 존재하지 않음
                MessageBox.Show("존재하지 않는 아이디입니다.", "로그인 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
