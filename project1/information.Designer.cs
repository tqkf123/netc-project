namespace Project1
{
    partial class information
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
            btnBuy = new Button();
            lbInfo = new Label();
            lbPrice = new Label();
            btnMinus = new Button();
            btnPlus = new Button();
            label4 = new Label();
            lbCount = new Label();
            pbImage = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            lbTotalPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(210, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 0;
            label1.Text = "상품정보";
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(167, 543);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(207, 43);
            btnBuy.TabIndex = 1;
            btnBuy.Text = "장바구니 담기";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // lbInfo
            // 
            lbInfo.Anchor = AnchorStyles.None;
            lbInfo.AutoSize = true;
            lbInfo.Location = new Point(3, 0);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(12, 15);
            lbInfo.TabIndex = 2;
            lbInfo.Text = "-";
            lbInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbPrice.Location = new Point(272, 363);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(63, 25);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "label3";
            lbPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinus.Location = new Point(416, 356);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(43, 38);
            btnMinus.TabIndex = 4;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlus.Location = new Point(365, 356);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(43, 38);
            btnPlus.TabIndex = 4;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(365, 412);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 5;
            label4.Text = "수량";
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbCount.Location = new Point(438, 412);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(22, 25);
            lbCount.TabIndex = 5;
            lbCount.Text = "0";
            // 
            // pbImage
            // 
            pbImage.Location = new Point(89, 60);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(359, 199);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 6;
            pbImage.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(166, 369);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 7;
            label2.Text = "가격 : \\";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(lbInfo);
            panel1.Location = new Point(66, 269);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 66);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(300, 464);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 7;
            label3.Text = "총 가격 : \\";
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.AutoSize = true;
            lbTotalPrice.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbTotalPrice.Location = new Point(438, 464);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(22, 25);
            lbTotalPrice.TabIndex = 3;
            lbTotalPrice.Text = "0";
            lbTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // information
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 681);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pbImage);
            Controls.Add(lbCount);
            Controls.Add(label4);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(lbTotalPrice);
            Controls.Add(lbPrice);
            Controls.Add(btnBuy);
            Controls.Add(label1);
            Name = "information";
            Text = "information";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBuy;
        private Label lbInfo;
        private Label lbPrice;
        private Button btnMinus;
        private Button btnPlus;
        private Label label4;
        private Label lbCount;
        private PictureBox pbImage;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label lbTotalPrice;
    }
}