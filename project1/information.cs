using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace Project1

{

    public partial class information : Form

    {

        private int currentQuantity = 0;
        private int basePrice = 0;

        public information(string productName, string description, string price, string imagePath)

        {

            InitializeComponent();


            this.Text = productName;

            lbInfo.Text = description;

            lbPrice.Text = price;

            try
            {
                // '원'이나 ',' 같은 문자들을 제거하고 숫자만 남깁니다.
                string priceDigits = new string(price.Where(char.IsDigit).ToArray());
                if (int.TryParse(priceDigits, out int parsedPrice))
                {
                    basePrice = parsedPrice; // 숫자 가격을 basePrice 변수에 저장
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("가격 정보를 읽어오는 데 실패했습니다: " + ex.Message);
            }

            try
            {
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    pbImage.Image = System.Drawing.Image.FromFile(imagePath);
                    pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pbImage.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("이미지를 불러오는 중 오류가 발생했습니다: " + ex.Message);
            }

            UpdatePriceAndQuantity(); // 폼이 로드될 때 라벨들을 초기화합니다.
        }







        private void btnPlus_Click(object sender, EventArgs e)

        {
            currentQuantity++;
            UpdatePriceAndQuantity();
        }


        private void btnMinus_Click(object sender, EventArgs e)

        {

            if (currentQuantity > 0)

            {

                if (currentQuantity > 0)
                {
                    currentQuantity--;
                    UpdatePriceAndQuantity(); // 수량과 가격을 업데이트합니다.
                }

            }

        }
        private void UpdatePriceAndQuantity()
        {
            // 수량 라벨(lbCount) 업데이트
            lbCount.Text = currentQuantity.ToString();

            // 총 가격 계산
            int totalPrice = basePrice * currentQuantity;

            // **신규**: 총 가격 라벨(lbTotalPrice) 업데이트
            // 숫자를 천 단위 쉼표(,) 서식으로 바꾸고 '원'을 붙여줍니다.
            // (디자이너에 lbTotalPrice 라는 라벨이 추가되어 있어야 합니다.)
            lbTotalPrice.Text = totalPrice.ToString("N0") + "원";
        }

        private void UpdateCountLabel()

        {

            lbCount.Text = currentQuantity.ToString();

        }


        public information()

        {

            InitializeComponent();

            UpdatePriceAndQuantity();

        }

        private void btnBuy_Click(object sender, EventArgs e)

        {
            // 수량이 0보다 클 때만 장바구니에 추가
            if (currentQuantity > 0)
            {
                // 새로운 ListViewItem 생성
                ListViewItem item = new ListViewItem(this.Text); // chName (상품명)
                item.SubItems.Add(lbPrice.Text);                 // 가격
                item.SubItems.Add(currentQuantity.ToString());   // 수량

                // 정적 클래스(CartData)의 리스트에 아이템 추가
                CartData.CartItems.Add(item);

                MessageBox.Show("장바구니에 담았습니다!");
                this.Hide();
                Search searchform = new Search();
                searchform.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("수량을 1개 이상 선택해주세요.");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // 이 코드는 Information.cs의 디자이너 파일(Information.Designer.cs)에

        // lbInfo, lbPrice, pbImage 컨트롤이 추가되어 있다고 가정합니다.

    }

}