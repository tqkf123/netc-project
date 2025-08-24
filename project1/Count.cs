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
    public partial class Count : Form
    {
        public Count()
        {
            InitializeComponent();
            LoadCartItems();
        }
        public Count(string data)
        {
            InitializeComponent();
            textBox4.Text = data;
        }
        public string TextBox1
        {
            set { textBox4.Text = value; }
        }
        private void LoadCartItems()
        {
            // lvAll 리스트뷰를 초기화합니다.
            lvAll.Items.Clear();

            // 1. 중복 처리 단계: 상품명을 Key로 사용하여 마지막 아이템만 저장합니다.
            var uniqueCartItems = new Dictionary<string, ListViewItem>();
            foreach (var item in CartData.CartItems)
            {
                // 상품명(chName)을 Key로 사용합니다. (ListViewItem의 기본 Text 속성을 상품명으로 가정)
                string itemName = item.Text;
                // 같은 상품명이 있으면 새로운 아이템으로 덮어씁니다.
                uniqueCartItems[itemName] = item;
            }

            // 2. 총합계 계산 및 리스트뷰에 아이템 추가
            long totalPrice = 0; // 금액이 커질 수 있으므로 long 타입을 사용합니다.

            // 중복 처리가 완료된 아이템들만 순회합니다.
            foreach (var item in uniqueCartItems.Values)
            {
                // Clone()을 사용하여 원본을 복제 후 리스트뷰에 추가합니다.
                lvAll.Items.Add((ListViewItem)item.Clone());

                try
                {
                    // 가격(chPrice)과 수량(chCount)을 가져옵니다.
                    // (가격: 2번째 SubItem(인덱스 1), 수량: 3번째 SubItem(인덱스 2)으로 가정)
                    string priceString = item.SubItems[1].Text;
                    string countString = item.SubItems[2].Text;

                    // 쉼표(,)를 제거하고 숫자로 변환하여 계산합니다.
                    long price = long.Parse(priceString.Replace(",", ""));
                    int count = int.Parse(countString);

                    // 현재 아이템의 소계(가격 * 수량)를 총합계에 더합니다.
                    totalPrice += price * count;
                }
                catch (Exception ex)
                {
                    // 가격이나 수량이 숫자가 아닐 경우를 대비한 예외 처리
                    Console.WriteLine($"항목 계산 오류: {item.Text}, 오류: {ex.Message}");
                }
            }

            // 3. 계산된 총합계를 textBox1에 쉼표를 포함한 형식으로 표시합니다.
            textBox1.Text = totalPrice.ToString("N0"); // 예: 150000 -> "150,000"
        }

        private void btn_add_Click_Click(object sender, EventArgs e)
        {
            address addr = new address(this);
            addr.Show();
        }

        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPayInfo.Items.Clear();
            lbMember.Items.Clear();

            if (cbPay.SelectedIndex == 0)
            {
                lbPayInfo.Items.Add("일시불");
                lbPayInfo.Items.Add("3개월 할부");
                lbPayInfo.Items.Add("6개월 할부");
                lbPayInfo.Items.Add("12개월 할부");
                lbMember.Items.Add("통신사");
                lbMember.Items.Add("네이버");
                lbMember.Items.Add("쿠팡");
            }
            if (cbPay.SelectedIndex == 1)
            {
                lbPayInfo.Items.Add("네이버");
                lbPayInfo.Items.Add("카카오");
                lbPayInfo.Items.Add("쿠팡");
                lbPayInfo.Items.Add("페이코");
                lbMember.Items.Add("적용안됨");

            }
            if (cbPay.SelectedIndex == 2)
            {
                lbPayInfo.Items.Add("n포인트");
                lbPayInfo.Items.Add("a포인트");
                lbPayInfo.Items.Add("b포인트");
                lbPayInfo.Items.Add("c포인트");
                lbMember.Items.Add("통신사");
                lbMember.Items.Add("네이버");
                lbMember.Items.Add("쿠팡");
            }
            if (cbPay.SelectedIndex == 3)
            {
                lbPayInfo.Items.Add("농협");
                lbPayInfo.Items.Add("신한");
                lbPayInfo.Items.Add("국민");
                lbPayInfo.Items.Add("케이");
                lbMember.Items.Add("통신사");
                lbMember.Items.Add("네이버");
                lbMember.Items.Add("쿠팡");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPhone.Text == "" || textBox4.Text == "" || tbEmail.Text == "")
            {
                MessageBox.Show("회원 정보를 다시 입력하세요");
                return;
            }
            else if (cbPay.Text == "" || lbPayInfo.Text == "" || lbMember.Text == "")
            {
                MessageBox.Show("결제방법 및 정보를 다시 확인하세요.");
                return;
            }
            
            else
            {
                string str = cbPay.Text + "(으)로" + lbPayInfo.Text + "결재방법을" + "\n선택하셨습니다" + "\n결재 금액은 " + textBox1.Text + "원 입니다.";
                MessageBox.Show(str);
                this.Hide();
                Main1 searchform = new Main1();
                searchform.ShowDialog();
                this.Close();
            }
        }

        private void btCheck2_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPhone.Text == "" || textBox4.Text == "" || tbEmail.Text == "")
            {
                MessageBox.Show("회원 정보를 다시 입력하세요");
            }
            if (!radioButton1.Checked || !radioButton2.Checked || !radioButton3.Checked || !radioButton4.Checked)
            {
                MessageBox.Show("사은품 종류를 골라주세요.");
            }

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show("금액이 확인됐습니다.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메인 화면으로 돌아갑니다.");
            this.Hide();
            Search searchform = new Search();
            searchform.ShowDialog();
            this.Close();
        }
    }
}
