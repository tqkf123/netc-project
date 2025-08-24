namespace Project1
{
    partial class Blankit
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(199, 24);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 0;
            label1.Text = "장바구니";
            // 
            // lvAll
            // 
            lvAll.Columns.AddRange(new ColumnHeader[] { chName, chPrice, chCount });
            lvAll.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lvAll.GridLines = true;
            lvAll.Location = new Point(40, 76);
            lvAll.Name = "lvAll";
            lvAll.Size = new Size(440, 441);
            lvAll.TabIndex = 1;
            lvAll.UseCompatibleStateImageBehavior = false;
            lvAll.View = View.Details;
            // 
            // chName
            // 
            chName.Text = "이름";
            chName.Width = 160;
            // 
            // chPrice
            // 
            chPrice.Text = "가격";
            chPrice.Width = 160;
            // 
            // chCount
            // 
            chCount.Text = "수량";
            chCount.Width = 120;
            // 
            // button1
            // 
            button1.Location = new Point(106, 582);
            button1.Name = "button1";
            button1.Size = new Size(131, 41);
            button1.TabIndex = 2;
            button1.Text = "메인화면";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(294, 582);
            button2.Name = "button2";
            button2.Size = new Size(131, 41);
            button2.TabIndex = 2;
            button2.Text = "결제화면";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(281, 533);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 32);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(199, 536);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 4;
            label2.Text = "총 금액";
            // 
            // Blankit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 681);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lvAll);
            Controls.Add(label1);
            Name = "Blankit";
            Text = "Blankit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lvAll;
        private ColumnHeader chName;
        private ColumnHeader chPrice;
        private ColumnHeader chCount;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label2;
    }
}