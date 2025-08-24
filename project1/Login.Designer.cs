namespace Project1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            btnLogin = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btHome = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(184, 160);
            label1.Name = "label1";
            label1.Size = new Size(153, 43);
            label1.TabIndex = 0;
            label1.Text = "login Menu";
            // 
            // btnLogin
            // 
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.Location = new Point(113, 368);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(285, 46);
            btnLogin.TabIndex = 1;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 234);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 282);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(252, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(134, 234);
            label2.Name = "label2";
            label2.Size = new Size(23, 23);
            label2.TabIndex = 4;
            label2.Text = "id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(90, 284);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btHome
            // 
            btHome.BackColor = Color.Transparent;
            btHome.BackgroundImage = Properties.Resources.free_icon_home_button_4849108;
            btHome.BackgroundImageLayout = ImageLayout.Stretch;
            btHome.FlatAppearance.BorderSize = 0;
            btHome.FlatStyle = FlatStyle.Flat;
            btHome.Image = Properties.Resources.free_icon_home_button_4849108;
            btHome.Location = new Point(0, 0);
            btHome.Name = "btHome";
            btHome.Size = new Size(53, 45);
            btHome.TabIndex = 5;
            btHome.UseVisualStyleBackColor = false;
            btHome.Click += btHome_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Location = new Point(73, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(373, 477);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 681);
            Controls.Add(btHome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogin;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button btHome;
        private PictureBox pictureBox1;
    }
}