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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            // 1. 현재 창(Main1)을 숨깁니다.
            this.Hide();

            // 2. Login 창의 새 인스턴스를 생성합니다.
            Drawer drawerForm = new Drawer();

            // 3. Login 창을 엽니다. ShowDialog()는 이 창이 닫힐 때까지 다른 창을 제어할 수 없게 합니다.
            drawerForm.ShowDialog();

            // 4. Login 창이 닫히고 나면, 숨겨두었던 Main1 창을 마저 닫아 프로그램을 종료합니다.
            this.Close();
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            // 1. 현재 창(Main1)을 숨깁니다.
            this.Hide();

            // 2. Login 창의 새 인스턴스를 생성합니다.
            Chair chairForm = new Chair();

            // 3. Login 창을 엽니다. ShowDialog()는 이 창이 닫힐 때까지 다른 창을 제어할 수 없게 합니다.
            chairForm.ShowDialog();

            // 4. Login 창이 닫히고 나면, 숨겨두었던 Main1 창을 마저 닫아 프로그램을 종료합니다.
            this.Close();
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            // 1. 현재 창(Main1)을 숨깁니다.
            this.Hide();

            // 2. Login 창의 새 인스턴스를 생성합니다.
            Bed bedForm = new Bed();

            // 3. Login 창을 엽니다. ShowDialog()는 이 창이 닫힐 때까지 다른 창을 제어할 수 없게 합니다.
            bedForm.ShowDialog();

            // 4. Login 창이 닫히고 나면, 숨겨두었던 Main1 창을 마저 닫아 프로그램을 종료합니다.
            this.Close();
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            // 1. 현재 창(Main1)을 숨깁니다.
            this.Hide();

            // 2. Login 창의 새 인스턴스를 생성합니다.
            Table tableForm = new Table();

            // 3. Login 창을 엽니다. ShowDialog()는 이 창이 닫힐 때까지 다른 창을 제어할 수 없게 합니다.
            tableForm.ShowDialog();

            // 4. Login 창이 닫히고 나면, 숨겨두었던 Main1 창을 마저 닫아 프로그램을 종료합니다.
            this.Close();
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            // 1. 현재 창(Main1)을 숨깁니다.
            this.Hide();

        // 2. Login 창의 새 인스턴스를 생성합니다.
        Interial  Interialform = new Interial();

            // 3. Login 창을 엽니다. ShowDialog()는 이 창이 닫힐 때까지 다른 창을 제어할 수 없게 합니다.
            Interialform.ShowDialog();

            // 4. Login 창이 닫히고 나면, 숨겨두었던 Main1 창을 마저 닫아 프로그램을 종료합니다.
            this.Close();
        }

        private void btbB6_Click(object sender, EventArgs e)
        {
            // 1. 현재 창(Main1)을 숨깁니다.
            this.Hide();

            // 2. Login 창의 새 인스턴스를 생성합니다.
            Rug rugForm = new Rug();

            // 3. Login 창을 엽니다. ShowDialog()는 이 창이 닫힐 때까지 다른 창을 제어할 수 없게 합니다.
            rugForm.ShowDialog();

            // 4. Login 창이 닫히고 나면, 숨겨두었던 Main1 창을 마저 닫아 프로그램을 종료합니다.
            this.Close();
        }

        private void btnB7_Click(object sender, EventArgs e)
        {
            // 1. 현재 창(Main1)을 숨깁니다.
            this.Hide();

            // 2. Login 창의 새 인스턴스를 생성합니다.
            Christ christForm = new Christ();

            // 3. Login 창을 엽니다. ShowDialog()는 이 창이 닫힐 때까지 다른 창을 제어할 수 없게 합니다.
            christForm.ShowDialog();

            // 4. Login 창이 닫히고 나면, 숨겨두었던 Main1 창을 마저 닫아 프로그램을 종료합니다.
            this.Close();
        }

        private void btnB8_Click(object sender, EventArgs e)
        {
            // 1. 현재 창(Main1)을 숨깁니다.
            this.Hide();

            // 2. Login 창의 새 인스턴스를 생성합니다.
            Gasun gasunForm = new Gasun();

            // 3. Login 창을 엽니다. ShowDialog()는 이 창이 닫힐 때까지 다른 창을 제어할 수 없게 합니다.
            gasunForm.ShowDialog();

            // 4. Login 창이 닫히고 나면, 숨겨두었던 Main1 창을 마저 닫아 프로그램을 종료합니다.
            this.Close();
        }

        private void btnB9_Click(object sender, EventArgs e)
        {
            // 1. 현재 창(Main1)을 숨깁니다.
            this.Hide();

            // 2. Login 창의 새 인스턴스를 생성합니다.
            Tools toolsForm = new Tools();

            // 3. Login 창을 엽니다. ShowDialog()는 이 창이 닫힐 때까지 다른 창을 제어할 수 없게 합니다.
            toolsForm.ShowDialog();

            // 4. Login 창이 닫히고 나면, 숨겨두었던 Main1 창을 마저 닫아 프로그램을 종료합니다.
            this.Close();
        }

        private void btnBMain_Click(object sender, EventArgs e)
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
            this.Close();
        }
    }
}
