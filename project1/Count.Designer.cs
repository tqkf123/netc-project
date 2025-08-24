namespace Project1
{
    partial class Count
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lvAll = new ListView();
            chName = new ColumnHeader();
            chPrice = new ColumnHeader();
            chCount = new ColumnHeader();
            btnPay = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            btCheck2 = new Button();
            tbName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tbPhone = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            btn_add_Click = new Button();
            tbEmail = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnCheck = new Button();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            lbPayInfo = new ListBox();
            cbPay = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            lbMember = new ListBox();
            label12 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "결제화면";
            // 
            // lvAll
            // 
            lvAll.Columns.AddRange(new ColumnHeader[] { chName, chPrice, chCount });
            lvAll.GridLines = true;
            lvAll.Location = new Point(12, 77);
            lvAll.Name = "lvAll";
            lvAll.Size = new Size(245, 111);
            lvAll.TabIndex = 0;
            lvAll.UseCompatibleStateImageBehavior = false;
            lvAll.View = View.Details;
            // 
            // chName
            // 
            chName.Text = "이름";
            chName.Width = 80;
            // 
            // chPrice
            // 
            chPrice.Text = "가격";
            chPrice.Width = 100;
            // 
            // chCount
            // 
            chCount.Text = "수량";
            chCount.Width = 50;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(267, 646);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(75, 23);
            btnPay.TabIndex = 1;
            btnPay.Text = "결제";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // button2
            // 
            button2.Location = new Point(170, 646);
            button2.Name = "button2";
            button2.Size = new Size(72, 23);
            button2.TabIndex = 2;
            button2.Text = "취소";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(267, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 52);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "총금액";
            // 
            // btCheck2
            // 
            btCheck2.Location = new Point(361, 449);
            btCheck2.Name = "btCheck2";
            btCheck2.Size = new Size(75, 23);
            btCheck2.TabIndex = 5;
            btCheck2.Text = "정보 확인";
            btCheck2.UseVisualStyleBackColor = true;
            btCheck2.Click += btCheck2_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(49, 359);
            tbName.Name = "tbName";
            tbName.Size = new Size(101, 23);
            tbName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 329);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "회원정보";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 359);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 8;
            label4.Text = "이름";
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(49, 388);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(153, 23);
            tbPhone.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 388);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 8;
            label5.Text = "연락처";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(49, 417);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(293, 23);
            textBox4.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 417);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 8;
            label6.Text = "주소";
            // 
            // btn_add_Click
            // 
            btn_add_Click.Location = new Point(361, 417);
            btn_add_Click.Name = "btn_add_Click";
            btn_add_Click.Size = new Size(63, 23);
            btn_add_Click.TabIndex = 9;
            btn_add_Click.Text = "검색";
            btn_add_Click.UseVisualStyleBackColor = true;
            btn_add_Click.Click += btn_add_Click_Click;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(49, 446);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(208, 23);
            tbEmail.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 449);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 8;
            label7.Text = "이메일";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 208);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 7;
            label8.Text = "사은품 선택";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 52);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 7;
            label9.Text = "주문 내역";
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(267, 165);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(75, 23);
            btnCheck.TabIndex = 10;
            btnCheck.Text = "금액 확인";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 237);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 89);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "사은품 종류(필수)";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(317, 62);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(61, 19);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "모니터";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(37, 62);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(96, 19);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "5,000 포인트";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(317, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(61, 19);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "상품권";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(37, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(49, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "조명";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // lbPayInfo
            // 
            lbPayInfo.FormattingEnabled = true;
            lbPayInfo.ItemHeight = 15;
            lbPayInfo.Location = new Point(170, 527);
            lbPayInfo.Name = "lbPayInfo";
            lbPayInfo.Size = new Size(140, 94);
            lbPayInfo.TabIndex = 12;
            // 
            // cbPay
            // 
            cbPay.FormattingEnabled = true;
            cbPay.Items.AddRange(new object[] { "신용카드", "간편결제", "포인트", "무통장입금" });
            cbPay.Location = new Point(12, 527);
            cbPay.Name = "cbPay";
            cbPay.Size = new Size(124, 23);
            cbPay.TabIndex = 13;
            cbPay.SelectedIndexChanged += cbPay_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 500);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 14;
            label10.Text = "결제방법";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(170, 500);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 14;
            label11.Text = "결재정보";
            // 
            // lbMember
            // 
            lbMember.FormattingEnabled = true;
            lbMember.ItemHeight = 15;
            lbMember.Location = new Point(344, 527);
            lbMember.Name = "lbMember";
            lbMember.Size = new Size(140, 94);
            lbMember.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(344, 500);
            label12.Name = "label12";
            label12.Size = new Size(43, 15);
            label12.TabIndex = 14;
            label12.Text = "멤버쉽";
            // 
            // Count
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 681);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(cbPay);
            Controls.Add(lbMember);
            Controls.Add(lbPayInfo);
            Controls.Add(groupBox1);
            Controls.Add(btnCheck);
            Controls.Add(btn_add_Click);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(tbEmail);
            Controls.Add(textBox4);
            Controls.Add(tbPhone);
            Controls.Add(tbName);
            Controls.Add(btCheck2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(lvAll);
            Controls.Add(button2);
            Controls.Add(btnPay);
            Controls.Add(label1);
            Name = "Count";
            Text = "Count";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lvAll;
        private ColumnHeader chName;
        private ColumnHeader chPrice;
        private ColumnHeader chCount;
        private Button btnPay;
        private Button button2;
        private TextBox textBox1;
        private Label label2;
        private Button btCheck2;
        private TextBox tbName;
        private Label label3;
        private Label label4;
        private TextBox tbPhone;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private Button btn_add_Click;
        private TextBox tbEmail;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnCheck;
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ListBox lbPayInfo;
        private ComboBox cbPay;
        private Label label10;
        private Label label11;
        private ListBox lbMember;
        private Label label12;
    }
}