using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Resister : Form
    {
        // 사용자 데이터를 저장할 파일 경로
        private static readonly string FilePath = "users.txt";

        // 프로그램 전체에서 사용할 사용자 데이터 저장소 (Key: 아이디, Value: User 객체)
        public static Dictionary<string, User> Users = new Dictionary<string, User>();

        // 아이디 중복 확인을 통과했는지 여부를 저장하는 변수
        private bool isIdChecked = false;

        public Resister()
        {
            InitializeComponent(); // 이 메서드는 Resister.Designer.cs에 정의되어 있습니다.
            LoadUsersFromFile();
        }

        // (이전 답변에서 제공한 모든 이벤트 핸들러 및 메서드 코드는 여기에 그대로 유지됩니다)
        // ... button3_Click, btnRegister_Click, textBox1_TextChanged 등 ...
        // ... LoadUsersFromFile, SaveUsersToFile ...

        /// <summary>
        /// ID 중복 확인 버튼 (button3) 클릭 이벤트
        /// </summary>



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


        /// <summary>
        /// 아이디 텍스트박스의 내용이 변경될 때마다 'ID 확인' 상태를 초기화
        /// </summary>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            isIdChecked = false;
        }

        public static void LoadUsersFromFile()
        {
            if (Users.Count > 0 && Users.Any()) return;

            if (!File.Exists(FilePath)) return;

            string[] lines = File.ReadAllLines(FilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 4)
                {
                    var user = new User
                    {
                        Id = parts[0],
                        Password = parts[1],
                        PhoneNumber = parts[2],
                        Address = parts[3]
                    };
                    if (!Users.ContainsKey(user.Id))
                    {
                        Users.Add(user.Id, user);
                    }
                }
            }
        }

        private static void SaveUsersToFile()
        {
            var lines = Users.Values.Select(user => $"{user.Id}|{user.Password}|{user.PhoneNumber}|{user.Address}");
            File.WriteAllLines(FilePath, lines);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("아이디를 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Users.ContainsKey(id))
            {
                MessageBox.Show("이미 사용 중인 아이디입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isIdChecked = false;
            }
            else
            {
                MessageBox.Show("사용 가능한 아이디입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isIdChecked = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked)
            {
                MessageBox.Show("개인정보 수집 및 이용에 동의해야 합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!radioButton4.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("마케팅정보에 동의나 미동의를 체크 해 주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!isIdChecked)
            {
                MessageBox.Show("아이디 중복 확인을 먼저 해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = textBox1.Text;
            string password = textBox2.Text;
            string passwordConfirm = textBox3.Text;
            string phone = textBox4.Text;
            

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(passwordConfirm))
            {
                
                    MessageBox.Show("모든 항목을 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                
            }

            if (password != passwordConfirm)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }

            if (Users.ContainsKey(id))
            {
                MessageBox.Show("아이디가 방금 다른 사용자에 의해 등록되었습니다. 다른 아이디를 사용해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isIdChecked = false;
                return;
            }

            var newUser = new User
            {
                Id = id,
                Password = password,
                PhoneNumber = phone,
                
            };

            Users.Add(newUser.Id, newUser);
            SaveUsersToFile();

            MessageBox.Show("회원가입이 성공적으로 완료되었습니다!", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // 1. 현재 창(Main1)을 숨깁니다.
            this.Hide();

            // 2. Login 창의 새 인스턴스를 생성합니다.
            Main1 mainForm = new Main1();

            // 3. Login 창을 엽니다. ShowDialog()는 이 창이 닫힐 때까지 다른 창을 제어할 수 없게 합니다.
            mainForm.ShowDialog();

            // 4. Login 창이 닫히고 나면, 숨겨두었던 Main1 창을 마저 닫아 프로그램을 종료합니다.
            this.Close();
        }
    }

    // 사용자 정보를 하나의 단위로 관리하기 위한 클래스
    public class User
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
    


